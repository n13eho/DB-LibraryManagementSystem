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
    public partial class UC_selfHome : UserControl
    {
        private userInfo user;
        public UC_selfHome(userInfo theUser)
        {
            InitializeComponent();
            user = theUser;
            getBorrowedBooksNumer();
        }
        private void getBorrowedBooksNumer()
        {
            OdbcConnection con = new OdbcConnection(user.conString);
            con.Open();
            string sql = "select count(*) from br_record where uno = " + user.userId + " and r_date is NULL";
            OdbcCommand com = new OdbcCommand(sql, con);
            string number = Convert.ToString(com.ExecuteScalar());
            label_borrowed_num.Text = number;

            sql = "select count(*) from br_record where uno = " + user.userId;
            OdbcCommand com2 = new OdbcCommand(sql, con);
            number = Convert.ToString(com2.ExecuteScalar());
            history_br_num.Text = number;
            con.Close();
        }

        private void refresh_btt_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_selfHome_Load(object sender, EventArgs e)
        {

        }

        private void buttonDQYJ_Click(object sender, EventArgs e)
        {

        }
    }
}
