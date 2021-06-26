using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace LibraryManagementSystem
{
    /*************************************************************************
    【类名】             userInfo
    【功能】             保存用户名、用户密码哈希字符串
    【接口说明】          getUserInfo()、checkID()
    【开发者及日期】      Algernon, 2021/06/19
    【版本】             V1.0
    *************************************************************************/
    public class userInfo
    {
        // 账号和密码
        public string userId;
        private string userPass;

        // 连接数据库的string
        public string conString = connectDB.conString;

        public bool isValid = false; // 身份合法
        public bool isIllegal = false; // 读者身份合法（没有超期不还的现象）
        public bool isManager = false; // 是管理员
        public bool havewarn = false; // 是管理员
        public string userName = " ";


        public userInfo(string para_userId, string para_userPass)
        {
            this.userId = para_userId;
            this.userPass = para_userPass;

            if (checkID())
            {
                isValid = true;
                getUserInfo();
            }
            else isValid = false;

        }

        /*************************************************************************
        【函数名称】       getUserInfo
        【函数功能】       通过用户输入的userId，访问数据库，得到用户的信息：用户名称、是否是管理员、身份是否合法
        【参数】           无
        【访问变量】       userId, OdbcConnection
        【返回值】         无
        【使用情况】       没有调用其他函数；被构造函数userInfo::userInfo()使用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void getUserInfo()
        {
            OdbcConnection con = new OdbcConnection(conString);
            con.Open();
            string sql = "select * from user where uno = " + userId;
            OdbcCommand com = new OdbcCommand(sql, con);
            OdbcDataReader reader = com.ExecuteReader();
            while(reader.Read())
            {
                userName = Convert.ToString(reader[1]);
                isIllegal = Convert.ToString(reader[5])=="1" ? true:false;
                isManager = Convert.ToString(reader[6]) == "1" ? true : false;
                //System.Windows.Forms.MessageBox.Show(userName);
                //System.Windows.Forms.MessageBox.Show(isIllegal?"1":"0");
            }
            reader.Close();
            con.Close();
        }


        /*************************************************************************
        【函数名称】       checkID
        【函数功能】       通过用户输入的userId和用户输入的密码，访问数据库；检查密码正确性和用户身份
        【参数】           无
        【访问变量】       userId, userPass
        【返回值】         无
        【使用情况】       没有调用其他函数；被构造函数userInfo::userInfo()使用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private bool checkID()
        {// 用于和数据库相联，检查身份，并确认等级（普通用户还是管理员）
            //return true;
            //先将密码明文转为加密文
            byte[] passwordAndSaltBytes = System.Text.Encoding.UTF8.GetBytes(userId + userPass);
            byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);
            string hashString = Convert.ToBase64String(hashBytes);

            //System.Windows.Forms.MessageBox.Show(hashString);
            //连接数据库
            //string conString = "DSN=_library;UID=root;PWD=123456"; //ODBC的数据源名
            //string conString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=139.9.119.34;Port=3306;Uid=s2018302359;Pwd=GaussDB@123;Database=2018302359_library;"; //ODBC的数据源名
            OdbcConnection con = null;
            try
            {
                con = new OdbcConnection(conString);
                con.Open();

                // select
                string sql = "select hashed_password from user where uno = " + userId;
                //System.Windows.Forms.MessageBox.Show(sql_select);
                OdbcCommand com_select = new OdbcCommand(sql, con);
                string hashed_pass = Convert.ToString(com_select.ExecuteScalar());
                Console.WriteLine(hashed_pass);

                //进行判定
                if (hashed_pass == hashString)
                    return true;
                else return false;

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("请检查网络连接，且需要输入用户ID！", "ERROR");
                havewarn = true;
            }
            finally
            {
                con.Close();
            }
            return false;// 顺利的话是不会执行到这里的
        }

    }
}
