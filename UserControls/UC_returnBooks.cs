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
    【类名】             UC_returnBooks
    【功能】             还书
    【接口说明】         showMyBooks()、return_butt_Click(object sender, EventArgs e)、button1_Click(object sender, EventArgs e)、dgv_mybook_CellContentClick(object sender, DataGridViewCellEventArgs e)
    【开发者及日期】      Algernon, 2021/06/19
    【版本】             V1.0
    *************************************************************************/
    public partial class UC_returnBooks : UserControl
    {
        private int chosen_book_index = -1;
        private string bno = "999";
        private userInfo user;

        /*************************************************************************
        【函数名称】       UC_returnBooks
        【函数功能】       类构造函数
        【参数】           userInfo theUser
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用InitializeComponent()、showMyBooks()；被FormDBoard new新窗体时使用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        public UC_returnBooks(userInfo theUser)
        {
            InitializeComponent();
            user = theUser;

            // 显示已经借了的书
            showMyBooks();
        }

        /*************************************************************************
        【函数名称】       showMyBooks
        【函数功能】       通过信息陈列用户已经借的书
        【参数】           无
        【访问变量】       无
        【返回值】         无
        【使用情况】       无调用函数；被构造函数调用调用、被函数button1_Click调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void showMyBooks()
        {
            dgv_mybook.Rows.Clear();
            // 连接数据库
            OdbcConnection con = new OdbcConnection(user.conString);
            con.Open();
            string sql = "select book.bno, bname, author, b_date from book, br_record where book.bno = br_record.bno and uno = " + user.userId + " and r_date is NULL;";
            OdbcCommand com = new OdbcCommand(sql, con);
            OdbcDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                int index = dgv_mybook.Rows.Add();
                for (int i = 0; i < reader.FieldCount; i++)
                {// 填进去
                    dgv_mybook.Rows[index].Cells[i].Value = Convert.ToString(reader[i]);
                }
            }

        }

        private void UC_returnBooks_Load(object sender, EventArgs e)
        {

        }

        /*************************************************************************
        【函数名称】       return_butt_Click
        【函数功能】       选中还书
        【参数】           object sender, EventArgs e
        【访问变量】       chosen_book_index
        【返回值】         无
        【使用情况】       无调用函数；被鼠标点击‘选中还书’按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void return_butt_Click(object sender, EventArgs e)
        {
            if(chosen_book_index < 0)
            {
                MessageBox.Show("请选择一本书先", "Error");
                return;
            }

            // 还书成功 1.在借书记录上记录上还书时间；2.在图书信息中isBorrowed更改为0

            // 借书成功 1.在借书记录上添加相关借阅记录；2.把这本书的状态标记为已借出（及时更新）
            OdbcConnection con = new OdbcConnection(user.conString);
            con.Open();
            string sql1 = "update br_record set r_date = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where bno = " + bno + " and uno = " + user.userId;
            //MessageBox.Show(sql1);
            string sql2 = "update book set isBorrowed = 0 where bno = " + bno;
            OdbcCommand com1 = new OdbcCommand(sql1, con);
            com1.ExecuteNonQuery();
            OdbcCommand com2 = new OdbcCommand(sql2, con);
            com2.ExecuteNonQuery();

            MessageBox.Show("还书成功！\n按刷新键刷新", "消息");
            con.Close();
        }


        /*************************************************************************
        【函数名称】       button1_Click
        【函数功能】       显示已经借了的书
        【参数】           object sender, EventArgs e
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用showMyBooks函数；被鼠标点击动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            // 显示已经借了的书
            showMyBooks();
        }

        /*************************************************************************
        【函数名称】       dgv_mybook_CellContentClick
        【函数功能】       更新所选行数， 更新chosen_book_index
        【参数】           object sender, DataGridViewCellEventArgs e
        【访问变量】       e.RowIndex
        【返回值】         无
        【使用情况】       无调用函数；被鼠标单击某一行动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void dgv_mybook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 给全局变量index赋值
                chosen_book_index = e.RowIndex;
                // 给全局变量bno赋值
                bno = dgv_mybook.Rows[e.RowIndex].Cells[0].Value.ToString();
                
            }
        }
    }
}
