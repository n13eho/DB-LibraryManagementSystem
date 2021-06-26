using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace LibraryManagementSystem.UserControls
{
    /*************************************************************************
    【类名】             UCM_manageUsers
    【功能】             用户管理
    【接口说明】         refreash_butt_Click(object sender, EventArgs e)、ssearch_butt_Click(object sender, EventArgs e)、dgv_manageUsers_CellClick(object sender, DataGridViewCellEventArgs e)、illegal_butt_Click(object sender, EventArgs e)、isHoldingBook()、delete_butt_Click(object sender, EventArgs e)、delete_butt_Click(object sender, EventArgs e)
    【开发者及日期】      Algernon, 2021/06/19
    【版本】             V1.0
    *************************************************************************/
    public partial class UCM_manageUsers : UserControl
    {
        private userInfo user;
        private int chosen_book_index = -1;
        private string uno;
        private string uname;

        //private connectDB condb;

        /*************************************************************************
        【函数名称】       UCM_manageUsers
        【函数功能】       类构造函数
        【参数】           userInfo theUser
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用InitializeComponent()、showAllUsers()；被FormDBoard new新窗体时使用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        public UCM_manageUsers(userInfo thUser)
        {
            InitializeComponent();
            user = thUser;

            showAllUsers();
        }

        /*************************************************************************
        【函数名称】       showAllUsers
        【函数功能】       显示所有用户
        【参数】           无
        【访问变量】       dgv_manageUsers
        【返回值】         无
        【使用情况】       无调用函数；被构造函数调用调用、被函数refreash_butt_Click调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void showAllUsers()
        {
            dgv_manageUsers.Rows.Clear();
            // 连接数据库
            OdbcConnection con = new OdbcConnection(user.conString);
            con.Open();
            string sql = "select uno, uname, tele_n, isIllegal from user;";
            OdbcCommand com = new OdbcCommand(sql, con);
            OdbcDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                int index = dgv_manageUsers.Rows.Add();
                for (int i = 0; i < reader.FieldCount; i++)
                {// 填进去
                    dgv_manageUsers.Rows[index].Cells[i].Value = Convert.ToString(reader[i]);
                }
            }
        }

        /*************************************************************************
        【函数名称】       refreash_butt_Click
        【函数功能】       刷新用户列表
        【参数】           object sender, EventArgs e
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用showAllUsers函数；被鼠标点击‘刷新’按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void refreash_butt_Click(object sender, EventArgs e)
        {
            showAllUsers();
        }


        /*************************************************************************
        【函数名称】       ssearch_butt_Click
        【函数功能】       搜索用户
        【参数】           object sender, EventArgs e
        【访问变量】       无
        【返回值】         无
        【使用情况】       无调用函数；被鼠标点击‘搜索’按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void ssearch_butt_Click(object sender, EventArgs e)
        {
            // 先清空
            dgv_manageUsers.Rows.Clear();
            // 定义变量
            string searchBy = "*";
            string sql;

            //处理两个textbox的内容
            if (cbb_search.Text == "工号") searchBy = "uno";
            else if (cbb_search.Text == "姓名") searchBy = "uname";
            else searchBy = "uname";

            if (tb_search.Text == "") sql = "select uno, uname, tele_n, isIllegal from user;";
            else if(connectDB.SqlInject(tb_search.Text))
            {
                MessageBox.Show("你想干什么！？", "检测到sql注入");
                tb_search.Text = "";
                return;
            }
            else sql = "select uno, uname, tele_n, isIllegal from user where " + searchBy + " like '%" + tb_search.Text + "%'";

            //MessageBox.Show(sql);

            // 连接数据库
            try
            {
                OdbcConnection con = new OdbcConnection(user.conString);
                con.Open();

                OdbcCommand com = new OdbcCommand(sql, con);
                OdbcDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    int index = dgv_manageUsers.Rows.Add();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {// 填进去
                        dgv_manageUsers.Rows[index].Cells[i].Value = Convert.ToString(reader[i]);
                    }
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("请输入合法的搜索字符", "ERROR");
            }
            finally
            {
                ;
            }

        }
        private string isIllegal;


        /*************************************************************************
        【函数名称】       dgv_manageUsers_CellClick
        【函数功能】       选中某一行，更新chosen_book_index
        【参数】           object sender, DataGridViewCellEventArgs e
        【访问变量】       e.RowIndex
        【返回值】         无
        【使用情况】       无调用函数；被鼠标单击某一行动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void dgv_manageUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 给全局变量index赋值
                chosen_book_index = e.RowIndex;
                // 给全局变量bno赋值
                uno = dgv_manageUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                uname = dgv_manageUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                isIllegal = dgv_manageUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        /*************************************************************************
        【函数名称】       illegal_butt_Click
        【函数功能】       设置非法用户
        【参数】           object sender, EventArgs e
        【访问变量】       chosen_book_index
        【返回值】         无
        【使用情况】       无调用函数；被鼠标点击‘更改身份合法性’按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void illegal_butt_Click(object sender, EventArgs e)
        {
            if(uno == "2018302359")
            {// 总不能把自己设为非法...
                MessageBox.Show("你有事？", "你有事？");
                return;
            }
            if (chosen_book_index >= 0)
            {//更改它的合法性
                //MessageBox.Show(isIllegal);
                if(isIllegal == null)
                {
                    MessageBox.Show("请选择一个人先", "Error");
                }

                if (isIllegal == "1")
                {// 合法变为不合法
                    DialogResult result = MessageBox.Show("确定要将用户 " + uname + " 的合法性变为 不合法 吗？", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        // 连接数据库
                        OdbcConnection con = new OdbcConnection(user.conString);
                        con.Open();
                        string sql = "update user set isIllegal=0 where uno like '" + uno + "';";
                        OdbcCommand com = new OdbcCommand(sql, con);
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("更改成功！", "Success");
                    }
                    else
                    {
                        ;
                    }
                }
                else if(isIllegal == "0")
                {// 不合法变为合法
                    DialogResult result = MessageBox.Show("确定要将用户 " + uname + " 的合法性变为 合法 吗？", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        // 连接数据库
                        OdbcConnection con = new OdbcConnection(user.conString);
                        con.Open();
                        string sql = "update user set isIllegal=1 where uno like '" + uno + "';";
                        OdbcCommand com = new OdbcCommand(sql, con);
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("更改成功！", "Success");
                    }
                    else
                    {
                        ;
                    }
                }
            }
            else
                MessageBox.Show("请选择一个人先", "Error");
        }

        /*************************************************************************
        【函数名称】       isHoldingBook
        【函数功能】       判断该用户是否正借有图书
        【参数】           无
        【访问变量】       user、uno
        【返回值】         bool型变量，该读者是否正借书
        【使用情况】       无调用函数；被函数delete_butt_Click调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private bool isHoldingBook()
        {
            OdbcConnection con = new OdbcConnection(user.conString);
            con.Open();
            //string sql = "select count(*) from br_record where uno = " + user.userId + " and r_date is NULL";
            // find bug uno用错了
            string sql = "select count(*) from br_record where uno = " + uno + " and r_date is NULL";
            OdbcCommand com = new OdbcCommand(sql, con);
            string number = Convert.ToString(com.ExecuteScalar());
            if (number != "0")
            {// 正在借阅的书数量不为0
                return true;
            }
            else return false;
        }

        /*************************************************************************
        【函数名称】       delete_butt_Click
        【函数功能】       删除选中的用户：如果用户时管理员或者正持有图书，则不能删除
        【参数】           object sender, EventArgs e
        【访问变量】       uname、uno
        【返回值】         无
        【使用情况】       无调用函数；被鼠标点击‘选中删除’按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void delete_butt_Click(object sender, EventArgs e)
        {
            if (uno == "2018302359")
            {// 总不能把自己设为非法...
                MessageBox.Show("那我走？", "那我走？");
                return;
            }
            if (uname != null)
            {//删除这个人
                if (isHoldingBook())
                {
                    MessageBox.Show("该用户正持有图书，联系他还书后再进行删除", "Error");
                }
                else
                {
                    DialogResult result = MessageBox.Show("确定要删除用户 " + uname + " 吗？", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        // 连接数据库
                        OdbcConnection con = new OdbcConnection(user.conString);
                        con.Open();
                        string sql = "DELETE FROM user WHERE (`uno` = '" + uno + "');";
                        OdbcCommand com = new OdbcCommand(sql, con);
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("删除成功！", "Success");
                    }
                    else
                    {
                        ;
                    }
                }


            }
            else
                MessageBox.Show("请选择一个人先", "Error");

        }
    }
}
