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
using System.Text.RegularExpressions;

namespace LibraryManagementSystem.UserControls
{
    public partial class UC_recommend : UserControl
    {
        private userInfo user;
        public UC_recommend(userInfo theUser)
        {
            InitializeComponent();
            user = theUser;

        }

        private void clear_butt_Click(object sender, EventArgs e)
        {// clear
            tb_author.Text = "";
            tb_bookName.Text = "";
            tb_publisher.Text = "";
        }

        private void submit_butt_Click(object sender, EventArgs e)
        {
            Match m = Regex.Match(tb_bookName.Text, @".*[^\s]");
            //if (tb_author.Text == "" || tb_bookName.Text == "")
            if (!m.Success)
            {
                MessageBox.Show("请输入有效的书名和作者名！", "Error");
            }
            else
            {
                string uno = user.userId;
                string rc_bname = tb_bookName.Text;
                string rc_author = tb_author.Text;
                string rc_pHouse = tb_publisher.Text;
                string rc_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                if(rc_bname.Length >= 50 || rc_author.Length >= 20)
                {
                    MessageBox.Show("太长了，会炸的，重新输入plz", "ERROR");
                    tb_author.Text = "";
                    tb_bookName.Text = "";
                    tb_publisher.Text = "";
                }
                else
                {
                    OdbcConnection con = new OdbcConnection(user.conString);
                    con.Open();
                    string sql1 = "select count(*) from recommended_books where rc_bname = '" + rc_bname + "' and rc_author = '" + rc_author + "';";
                    OdbcCommand com1 = new OdbcCommand(sql1, con);
                    string res = Convert.ToString(com1.ExecuteScalar());

                    if (res == "0")
                    {// 原来的rc表上没有推荐过的
                        string sql2 = "insert into recommended_books values('" + uno + "', '" + rc_bname + "', '" + rc_author + "', '" + rc_pHouse + "', '" + rc_date + "')";
                        //MessageBox.Show(sql2);
                        OdbcCommand com2 = new OdbcCommand(sql2, con);
                        com2.ExecuteNonQuery();
                        MessageBox.Show("推荐成功！谢谢反馈！", "Success");

                    }
                    else
                    {// 这本书已经被推荐过了
                        MessageBox.Show("这本书已经被推荐过了", "Message");
                    }
                    con.Close();
                    tb_author.Text = "";
                    tb_bookName.Text = "";
                    tb_publisher.Text = "";
                }

            }
        }
    }
}
