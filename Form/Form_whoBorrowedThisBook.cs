using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    /*************************************************************************
    【类名】             Form_whoBorrowedThisBook
    【功能】             显示图书借阅信息的窗体
    【接口说明】          showInfo()、label5_Click(object sender, EventArgs e)、submit_Click(object sender, EventArgs e)
    【开发者及日期】      Algernon, 2021/06/19
    【版本】             1.0
    *************************************************************************/
    public partial class Form_whoBorrowedThisBook : Form
    {
        private string bno;
        private userInfo user;

        /***************************************************************
        【函数名称】         Form_whoBorrowedThisBook
        【函数功能】         构造函数、初始化窗口信息
        【参数】             输入参数：string bno, userInfo theUser
        【访问变量】         无
        【返回值】           无
        【使用情况】         调用InitializeComponent函数、showInfo函数;被UCM_manageBooks::dgv_manageBooks_CellDoubleClick函数调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        public Form_whoBorrowedThisBook(string bno, userInfo theUser)
        {
            InitializeComponent();
            this.bno = bno;
            this.user = theUser;

            showInfo();

        }

        /***************************************************************
        【函数名称】         showInfo
        【函数功能】         在窗口中显示图书借阅信息
        【参数】             无
        【访问变量】         OdbcConnection
        【返回值】           无
        【使用情况】         调用OdbcCommand::Open、ExecuteReader函数;被Form_whoBorrowedThisBook构造函数调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void showInfo()
        {
            // 连接数据库
            OdbcConnection con = new OdbcConnection(user.conString);
            con.Open();
            string sql = "select bname, uname, user.uno, b_date from user, book, br_record where user.uno = br_record.uno and book.bno = br_record.bno and book.bno like '" + bno + "';";
            OdbcCommand com = new OdbcCommand(sql, con);
            OdbcDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                bname_tb.Text = Convert.ToString(reader[0]);
                uname_tb.Text = Convert.ToString(reader[1]);
                uno_tb.Text = Convert.ToString(reader[2]);
                date_tb.Text = Convert.ToString(reader[3]);
                break;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        /***************************************************************
        【函数名称】         submit_Click
        【函数功能】         确认信息后关闭窗口
        【参数】             无
        【访问变量】         无
        【返回值】           无
        【使用情况】         调用Dispose函数;被鼠标点击选中“ok”按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void submit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
