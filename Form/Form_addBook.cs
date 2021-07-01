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
    【类名】             Form_addBook
    【功能】             向数据库增加图书信息的窗体
    【接口说明】          reset_butt_Click(object sender, EventArgs e)、clearTB()、submit_Click(object sender, EventArgs e)、
    【开发者及日期】      Algernon, 2021/06/19
    【版本】             V1.0
    *************************************************************************/
    public partial class Form_addBook : Form
    {
        private userInfo user;

        /*************************************************************************
        【函数名称】       Form_addBook
        【函数功能】       类的构造函数、初始化窗口信息
        【参数】           输入参数：userInfo theUser
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用InitializeComponent函数;被UCM_manageBooks::addBooks_butt_Click函数调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        public Form_addBook(userInfo theUser)
        {
            InitializeComponent();
            user = theUser;
        }
        
        /***************************************************************
        【函数名称】       reset_butt_Click
        【函数功能】       重置图书信息按钮
        【参数】           输入参数：object sender, EventArgs e
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用clearTB函数;被鼠标点击选中重置按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        ****************************************************************/

        private void reset_butt_Click(object sender, EventArgs e)
        {
            clearTB();
        }

        /***************************************************************
        【函数名称】         clearTB
        【函数功能】         重置图书信息：作者、书名、出版社、类型
        【参数】             输入参数：无
        【访问变量】         无
        【返回值】           无
        【使用情况】         没有调用其他函数；被reset_butt_Click函数、submit_Click函数调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void clearTB()
        {
            tb_author.Text = "";
            tb_bname.Text = "";
            tb_pu.Text = "";
            tb_type.Text = "";
        }

        /***************************************************************
        【函数名称】         submit_Click
        【函数功能】         提交新增图书信息
        【参数】             输入参数：object sender, EventArgs e
        【返回值】           无
        【访问变量】         tb_bname、tb_author、tb_pu、tb_type、OdbcConnection
        【使用情况】         调用MessageBox.Show()函数；被鼠标点击选中提交按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void submit_Click(object sender, EventArgs e)
        {
            string bname = tb_bname.Text, author = tb_author.Text, publisher = tb_pu.Text, b_type = tb_type.Text;
            

            if(bname == "" || author == "" || publisher == "" || b_type == "")
                MessageBox.Show("请完整输入相关信息！", "Error");
            else if(bname.Length >= 50 || author.Length >= 20 || publisher.Length >= 20 || b_type.Length >= 20)
                MessageBox.Show("太长了，会炸的，重新输入plz", "ERROR");
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
