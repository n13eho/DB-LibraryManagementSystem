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
    public partial class UCM_manageUsers : UserControl
    {
        private userInfo user;
        private int chosen_book_index = -1;
        private string uno;
        private string uname;

        //private connectDB condb;

        public UCM_manageUsers(userInfo thUser)
        {
            InitializeComponent();
            user = thUser;

            showAllUsers();
        }

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

        private void refreash_butt_Click(object sender, EventArgs e)
        {
            showAllUsers();
        }


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
