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
    /*************************************************************************
    【类名】             UC_recommend
    【功能】             推荐图书
    【接口说明】         clear_butt_Click(object sender, EventArgs e)、submit_butt_Click(object sender, EventArgs e)
    【开发者及日期】      Algernon, 2021/06/19
    【版本】             V1.0
    *************************************************************************/
    public partial class UC_recommend : UserControl
    {
        private userInfo user;

        /*************************************************************************
        【函数名称】       UC_recommend
        【函数功能】       类构造函数
        【参数】           userInfo theUser
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用InitializeComponent()；被FormDBoard new新窗体时使用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        public UC_recommend(userInfo theUser)
        {
            InitializeComponent();
            user = theUser;

        }


        /*************************************************************************
        【函数名称】       clear_butt_Click
        【函数功能】       重置，清空
        【参数】           object sender, EventArgs e
        【访问变量】       无
        【返回值】         无
        【使用情况】       无调用函数；被鼠标点击‘重置’按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void clear_butt_Click(object sender, EventArgs e)
        {// clear
            tb_author.Text = "";
            tb_bookName.Text = "";
            tb_publisher.Text = "";
        }

        /*************************************************************************
        【函数名称】       submit_butt_Click
        【函数功能】       提交推荐信息
        【参数】           object sender, EventArgs e
        【访问变量】       user.userId、tb_bookName.Text、tb_author.Text、tb_publisher.Text
        【返回值】         无
        【使用情况】       无调用函数；被鼠标点击提交按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void submit_butt_Click(object sender, EventArgs e)
        {
            Match bn = Regex.Match(tb_bookName.Text, @".*[^\s]");
            Match an = Regex.Match(tb_author.Text, @".*[^\s]");
            //if (tb_author.Text == "" || tb_bookName.Text == "")
            if (!bn.Success || !an.Success || connectDB.SqlInject(tb_bookName.Text) || connectDB.SqlInject(tb_author.Text))
            {// 对空输入和sql注入的检测
                MessageBox.Show("请输入合法且有效的书名和作者名！", "Error");
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
