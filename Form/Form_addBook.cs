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
    public partial class Form_addBook : Form
    {
        private userInfo user;
        public Form_addBook(userInfo theUser)
        {
            InitializeComponent();
            user = theUser;
        }

        private void reset_butt_Click(object sender, EventArgs e)
        {
            clearTB();
        }

        private void clearTB()
        {
            tb_author.Text = "";
            tb_bname.Text = "";
            tb_pu.Text = "";
            tb_type.Text = "";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string bname = tb_bname.Text, author = tb_author.Text, publisher = tb_pu.Text, b_type = tb_type.Text;
            

            if(bname == "" || author == "" || publisher == "" || b_type == "")
                MessageBox.Show("请完整输入相关信息！", "Error");
            else
            {
                string bno = Convert.ToString(DateTimeOffset.Now.ToUnixTimeSeconds());
                
                // 连接数据库
                OdbcConnection con = new OdbcConnection(user.conString);
                con.Open();
                string sql = "INSERT INTO book (`bno`, `bname`, `author`, `b_type`, `publisher`) VALUES ('" + bno + "', '" + bname + "', '" + author + " ', '" + b_type + "', '" + publisher + "')";

                //MessageBox.Show(sql);
                OdbcCommand com = new OdbcCommand(sql, con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("添加成功！", "Success");

                clearTB();
            }
        }
    }
}
