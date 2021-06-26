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
    public partial class UCM_manageBooks : UserControl
    {
        private userInfo user;
        private int chosen_book_index = -1;
        private string bno = "999";
        private string isBorrowed;
        public UCM_manageBooks(userInfo theUser)
        {
            InitializeComponent();
            user = theUser;
            showAllBooks();
        }

        private void showAllBooks()
        {
            dgv_manageBooks.Rows.Clear();
            // 连接数据库
            OdbcConnection con = new OdbcConnection(user.conString);
            con.Open();
            string sql = "select bno, bname, author, isBorrowed from book";
            OdbcCommand com = new OdbcCommand(sql, con);
            OdbcDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                int index = dgv_manageBooks.Rows.Add();
                for (int i = 0; i < reader.FieldCount; i++)
                {// 填进去
                    dgv_manageBooks.Rows[index].Cells[i].Value = Convert.ToString(reader[i]);
                }
            }
        }


        private void refreash_butt_Click(object sender, EventArgs e)
        {
            showAllBooks();
        }

        private void ssearch_butt_Click(object sender, EventArgs e)
        {
            // 先清空
            dgv_manageBooks.Rows.Clear();
            // 定义变量
            string searchBy = "*";
            string sql;

            //处理两个textbox的内容
            if (cbb_search.Text == "图书编号") searchBy = "bno";
            else if (cbb_search.Text == "图书名字") searchBy = "bname";
            else if (cbb_search.Text == "作者") searchBy = "author";
            else searchBy = "bname";
            
            if(tb_search.Text == "") sql = "select bno, bname, author, isBorrowed from book";
            else if (connectDB.SqlInject(tb_search.Text))
            {
                MessageBox.Show("你想干什么！？", "检测到sql注入");
                tb_search.Text = "";
                return;
            }
            else sql = "select bno, bname, author, isBorrowed from book where " + searchBy + " like '%" + tb_search.Text + "%'";

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
                    int index = dgv_manageBooks.Rows.Add();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {// 填进去
                        dgv_manageBooks.Rows[index].Cells[i].Value = Convert.ToString(reader[i]);
                    }
                }
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("请输入合法的搜索字符", "ERROR");
            }
            finally
            {
                ;
            }

        }
        private void dgv_manageBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 给全局变量index赋值
                chosen_book_index = e.RowIndex;
                // 给全局变量bno赋值
                bno = dgv_manageBooks.Rows[e.RowIndex].Cells[0].Value.ToString();
                isBorrowed = dgv_manageBooks.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void dgv_manageBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {//新出一个form显示谁借了这本书
            if (e.RowIndex >= 0 && isBorrowed == "1")
            {
                using (Form_whoBorrowedThisBook fub = new Form_whoBorrowedThisBook(bno, user))
                {
                    fub.ShowDialog();
                }

            }
        }

        private void update_butt_Click(object sender, EventArgs e)
        {// 选中修改
            if (chosen_book_index >= 0)
            {
                using (Form_updateBooks fub = new Form_updateBooks(bno, user))
                {
                    fub.ShowDialog();
                }
            }
            else MessageBox.Show("选择一本书先");
        }

        private void delete_butt_Click(object sender, EventArgs e)
        {
            if (chosen_book_index >= 0)
            {// 删除这个图书
                if (isBorrowed == "1")
                {
                    MessageBox.Show("此书已借出，先还书，后删除", "Error");
                }
                else
                {
                    DialogResult result = MessageBox.Show("确定要删除这本书吗？", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        // 连接数据库
                        OdbcConnection con = new OdbcConnection(user.conString);
                        con.Open();
                        string sql = "DELETE FROM book WHERE (`bno` = '" + bno + "');";
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
            else MessageBox.Show("选择一本书先");

        }

        private void addBooks_butt_Click(object sender, EventArgs e)
        {
            using (Form_addBook i = new Form_addBook(user))
            {
                i.ShowDialog();
            }
        }
    }
}
