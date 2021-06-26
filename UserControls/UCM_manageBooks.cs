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
    【类名】             UCM_manageBooks
    【功能】             管理员管理图书
    【接口说明】         showAllBooks()、refreash_butt_Click(object sender, EventArgs e)、ssearch_butt_Click(object sender, EventArgs e)、dgv_manageBooks_CellClick(object sender, DataGridViewCellEventArgs e)、dgv_manageBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)、update_butt_Click(object sender, EventArgs e)、delete_butt_Click(object sender, EventArgs e)、addBooks_butt_Click(object sender, EventArgs e)
    【开发者及日期】      Algernon, 2021/06/19
    【版本】             V1.0
    *************************************************************************/
    public partial class UCM_manageBooks : UserControl
    {
        private userInfo user;
        private int chosen_book_index = -1;
        private string bno = "999";
        private string isBorrowed;

        /*************************************************************************
        【函数名称】       UCM_manageBooks
        【函数功能】       类构造函数
        【参数】           userInfo theUser
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用InitializeComponent()、showAllBooks()；被FormDBoard new新窗体时使用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        public UCM_manageBooks(userInfo theUser)
        {
            InitializeComponent();
            user = theUser;
            showAllBooks();
        }

        /*************************************************************************
        【函数名称】       showAllBooks
        【函数功能】       显示所有书条目和相关信息
        【参数】           无
        【访问变量】        dgv_manageBooks表格
        【返回值】         无
        【使用情况】       无调用函数；被构造函数、refreash_butt_Click函数调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
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

        /*************************************************************************
        【函数名称】       refreash_butt_Click
        【函数功能】       刷新图书信息并显示
        【参数】           object sender, EventArgs e
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用showAllBooks函数；被鼠标点击‘刷新’按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void refreash_butt_Click(object sender, EventArgs e)
        {
            showAllBooks();
        }

        /*************************************************************************
        【函数名称】       return_butt_Click
        【函数功能】       根据关键词搜索图书
        【参数】           object sender, EventArgs e
        【访问变量】       dgv_manageBooks
        【返回值】         无
        【使用情况】       无调用函数；被鼠标点击‘搜索’按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
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


        /*************************************************************************
        【函数名称】       dgv_manageBooks_CellClick
        【函数功能】       选中某一行，更新选中行信息
        【参数】           object sender, DataGridViewCellEventArgs e
        【访问变量】       RowIndex
        【返回值】         无
        【使用情况】       无调用函数；被鼠标单击某一行动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
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

        /*************************************************************************
        【函数名称】       dgv_manageBooks_CellDoubleClick
        【函数功能】       双击显示图书信息，谁借了这本书
        【参数】           object sender, EventArgs e
        【访问变量】       e.RowIndex、isBorrowed
        【返回值】         无
        【使用情况】       调用函数fub.ShowDialog；被鼠标双击某一行图书动作作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
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

        /*************************************************************************
        【函数名称】       update_butt_Click
        【函数功能】       选中修改图书信息
        【参数】           object sender, EventArgs e
        【访问变量】       chosen_book_index
        【返回值】         无
        【使用情况】       调用函数fub.ShowDialog；被鼠标点击‘选中还书’按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
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

        /*************************************************************************
        【函数名称】       delete_butt_Click
        【函数功能】       删除所选图书
        【参数】           object sender, EventArgs e
        【访问变量】       chosen_book_index
        【返回值】         无
        【使用情况】       调用函数fub.ShowDialog；被鼠标点击‘选中删除’按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
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

        /*************************************************************************
        【函数名称】       addBooks_butt_Click
        【函数功能】       新增图书
        【参数】           object sender, EventArgs e
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用i.ShowDialog函数；被鼠标点击‘新增图书’按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void addBooks_butt_Click(object sender, EventArgs e)
        {
            using (Form_addBook i = new Form_addBook(user))
            {
                i.ShowDialog();
            }
        }
    }
}
