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
    /*************************************************************************
    【类名】             Form_updateBooks
    【功能】             向数据库更新图书信息的窗体
    【接口说明】         readNewInfo()、showOriInfo()、getBookInfo()、submit_Click(object sender, EventArgs e)、
    【开发者及日期】      Algernon, 2021/06/19
    【版本】             V1.0
    *************************************************************************/
    public partial class Form_updateBooks : Form
    {
        private userInfo user;

        private string bno;
        private string bname;
        private string author;
        private string publisher;
        private string isBorrowed;

        /***************************************************************
        【函数名称】       Form_updateBooks
        【函数功能】       构造函数、初始化窗体信息
        【参数】           输入参数：string bno, userInfo theUser
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用InitializeComponent函数、getBookInfo函数、showOriInfo函数;被UCM_manageBooks::update_butt_Click函数调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        ****************************************************************/

        public Form_updateBooks(string bno, userInfo theUser)
        {
            InitializeComponent();
            this.bno = bno;
            user = theUser;
            getBookInfo();
            showOriInfo();
        }

        /***************************************************************
        【函数名称】         readNewInfo
        【函数功能】         读取输入的最新图书信息
        【参数】             无
        【访问变量】         tb_bname、tb_author、tb_pu、tb_ib
        【返回值】           无
        【使用情况】         未调用其他函数;被submit_Click函数调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void readNewInfo()
        {
            bname = tb_bname.Text;
            author = tb_author.Text;
            publisher = tb_pu.Text;
            isBorrowed = tb_ib.Text;
        }

        /***************************************************************
        【函数名称】         showOriInfo
        【函数功能】         将原图书信息写入窗口
        【参数】             无
        【访问变量】         bname、author、publisher、isBorrowed
        【返回值】           无
        【使用情况】         未调用其他函数;被Form_updateBooks构造函数调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void showOriInfo()
        {
            tb_bname.Text = bname;
            tb_author.Text = author;
            tb_pu.Text = publisher;
            tb_ib.Text = isBorrowed;
        }
        

        /***************************************************************
        【函数名称】         getBookInfo
        【函数功能】         读取原图书信息
        【参数】             无
        【访问变量】         OdbcConnection
        【返回值】           无
        【使用情况】         调用OdbcCommand::ExecuteReader函数;被Form_updateBooks构造函数调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
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


        /***************************************************************
        【函数名称】         submit_Click
        【函数功能】         提交修改信息并反馈
        【参数】             输入参数：object sender, EventArgs e
        【访问变量】         OdbcConnection
        【返回值】           无
        【使用情况】         调用readNewInfo函数、OdbcCommand::Open、ExecuteNonQuery、Close函数、Dispose函数;被鼠标点击选中提交按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
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
