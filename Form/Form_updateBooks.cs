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
    public partial class Form_updateBooks : Form
    {
        private userInfo user;

        private string bno;
        private string bname;
        private string author;
        private string publisher;
        private string isBorrowed;

        public Form_updateBooks(string bno, userInfo theUser)
        {
            InitializeComponent();
            this.bno = bno;
            user = theUser;
            getBookInfo();
            showOriInfo();
        }

        private void readNewInfo()
        {
            // 更新信息
            bname = tb_bname.Text;
            author = tb_author.Text;
            publisher = tb_pu.Text;
            isBorrowed = tb_ib.Text;
        }

        private void showOriInfo()
        {
            tb_bname.Text = bname;
            tb_author.Text = author;
            tb_pu.Text = publisher;
            tb_ib.Text = isBorrowed;
        }

        private void getBookInfo()
        {
            OdbcConnection con = new OdbcConnection(user.conString);
            con.Open();
            string sql = "select bname, author, publisher, isBorrowed from book where bno like '" + bno + "';";
            OdbcCommand com = new OdbcCommand(sql, con);
            OdbcDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                bname = Convert.ToString(reader[0]);
                author = Convert.ToString(reader[1]);
                publisher = Convert.ToString(reader[2]);
                isBorrowed = Convert.ToString(reader[3]);
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            readNewInfo();

            OdbcConnection con = new OdbcConnection(user.conString);
            con.Open();
            string sql = "update book set bname = '" + bname + "', author = '" + author + "', publisher = '" + publisher + "', isBorrowed = '" + isBorrowed + "' where bno like '" + bno + "'; ";
            
            OdbcCommand com = new OdbcCommand(sql, con);
            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("修改图书信息成功", "Success!");
            this.Dispose();
        }
    }
}
