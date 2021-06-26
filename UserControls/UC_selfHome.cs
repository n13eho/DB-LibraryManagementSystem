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
    【类名】             UC_selfHome
    【功能】             个人中心
    【接口说明】         getBorrowedBooksNumer()
    【开发者及日期】      Algernon, 2021/06/19
    【版本】             V1.0
    *************************************************************************/
    public partial class UC_selfHome : UserControl
    {
        private userInfo user;

        /*************************************************************************
        【函数名称】       UC_selfHome
        【函数功能】       类构造函数
        【参数】           userInfo theUser
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用InitializeComponent()、getBorrowedBooksNumer()；被FormDBoard new新窗体时使用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        public UC_selfHome(userInfo theUser)
        {
            InitializeComponent();
            user = theUser;
            getBorrowedBooksNumer();
        }

        /*************************************************************************
        【函数名称】       getBorrowedBooksNumer
        【函数功能】       返回已借图书数量
        【参数】           无
        【访问变量】       user.userId
        【返回值】         无
        【使用情况】       无调用函数；被构造函数调用调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
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
