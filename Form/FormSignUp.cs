using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace LibraryManagementSystem
{
    /*************************************************************************
    【类名】              FormSignUp
    【功能】             登录窗口
    【接口说明】          label3_Click(object sender, EventArgs e)、translatePassword(string uno, string pass)、updateUserInfo()、updateUserInfo()、signUp_butt_Click(object sender, EventArgs e)、
    【开发者及日期】      Algernon, 2021/06/19
    【版本】             1.0
    *************************************************************************/
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        string uno, uname, ugender, tele_n, hashed_pass;
        int isIllegal, isManager;

        private string translatePassword(string uno, string pass)
        {
            byte[] passwordAndSaltBytes = System.Text.Encoding.UTF8.GetBytes(uno + pass);
            byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);
            string hashString = Convert.ToBase64String(hashBytes);
            return hashString;
        }

        private void updateUserInfo()
        {
            uno = uno_tb.Text;
            uname = uname_tb.Text;
            ugender = ugender_comb.Text;
            tele_n = tele_tb.Text;
            hashed_pass = translatePassword(uno, pass2_tb.Text);
            isIllegal = 1;
            isManager = 0;
        }

        private void signUp_butt_Click(object sender, EventArgs e)
        {
            if(uno_tb.Text == "" || uname_tb.Text == "" || pass_tb.Text == "" 
                || pass2_tb.Text == "" || ugender_comb.Text == "" || tele_tb.Text == "")
            {//没输入完整
                MessageBox.Show("请输入完整的信息", "Error");
            }
            else if (uno_tb.Text.Length != 10)
            {//
                MessageBox.Show("请正确输入10位的工号", "Error");
            }
            else if(pass_tb.Text != pass2_tb.Text)
            {//两次密码不一样
                MessageBox.Show("两次密码不一致，请重新校对后输入", "Error");
            }
            else
            {//insert了
                //先把变量准备好
                updateUserInfo();

                // 连接数据库
                OdbcConnection con = new OdbcConnection(connectDB.conString);
                con.Open();

                //检测uno是否已经用过了
                string sql0 = "select count(*) from user where uno = '" + uno + "';";
                OdbcCommand com0 = new OdbcCommand(sql0, con);
                string res = Convert.ToString(com0.ExecuteScalar());
                //做判断了
                if(res == "0")
                {//用户表上没有，则添加新用户
                    //插入inset
                    string sql = "insert user values('" + uno + "', '" + uname + "', '" + ugender + "', '" + tele_n + "', '" + hashed_pass + "', " + isIllegal + ", " + isManager + ")";
                    //MessageBox.Show(sql);
                    OdbcCommand com = new OdbcCommand(sql, con);
                    com.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("注册成功", "Success");
                    this.Dispose();
                }
                else
                {// 否则报错
                    MessageBox.Show("该工号已注册在案，请登录或重新注册", "Error");
                    this.Dispose();
                }


            }
        }
    }
}
