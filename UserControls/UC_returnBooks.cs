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
    public partial class UC_returnBooks : UserControl
    {
        private int chosen_book_index = -1;
        private string bno = "999";
        private userInfo user;
        public UC_returnBooks(userInfo theUser)
        {
            InitializeComponent();
            user = theUser;

            // 显示已经借了的书
            showMyBooks();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            // 显示已经借了的书
            showMyBooks();
        }

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
