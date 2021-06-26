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
    【类名】             UC_lookPB
    【功能】             查询检索书目、选中借书的用户控制面板
    【接口说明】          dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)、button1_Click(object sender, EventArgs e)、borrow_butt_Click(object sender, EventArgs e)、
    【开发者及日期】      Algernon, 2021/06/19
    【版本】             V1.0
    *************************************************************************/
    public partial class UC_lookPB : UserControl
    {
        // the chosen book's bno
        private string bno = "999";
        // the chosen book is borrowed
        private bool bookIsBorrowed = true;
        // the chosen book's index
        private int chosen_book_index = -1;
        // user info
        private userInfo user;

        /*************************************************************************
        【函数名称】       UC_lookPB
        【函数功能】       类构造函数
        【参数】           userInfo theUser
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用InitializeComponent()；被FormDBoard new新窗体时使用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        public UC_lookPB(userInfo theUser)
        {
            InitializeComponent();
            user = theUser;

            // dgw的基本设定
            dgw_search.AllowUserToResizeRows = false; // 禁拖动行高度
            dgw_search.GridColor = Color.DarkBlue;// 网格线
            dgw_search.AllowUserToAddRows = false;// 
            dgw_search.MultiSelect = false;//禁止多行选择
        }

        /*************************************************************************
        【函数名称】       dataGridView1_CellContentClick
        【函数功能】       获取用户鼠标选取的某一行，更新行号
        【参数】           object sender, DataGridViewCellEventArgs e
        【访问变量】       表格e.RowIndex行信息
        【返回值】         无
        【使用情况】       没有调用其他函数；被构造函数userInfo::userInfo()使用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {// 用于选择某一行的值
            if(e.RowIndex >= 0)
            {
                // 给全局变量index赋值
                chosen_book_index = e.RowIndex;
                // 给全局变量bno赋值
                bno = dgw_search.Rows[e.RowIndex].Cells[0].Value.ToString();
                // 检查是否借出去了
                if (dgw_search.Rows[e.RowIndex].Cells[5].Value.ToString() == "已借出")
                    bookIsBorrowed = true;
                else bookIsBorrowed = false;// 可借出去的状态
            }
        }


        /*************************************************************************
        【函数名称】       button1_Click
        【函数功能】       根据搜索条件和输入的关键词进行图书检索
        【参数】           object sender, EventArgs e
        【访问变量】       表格e.RowIndex行信息
        【返回值】         无
        【使用情况】       调用dgw_search.Rows.Clear()、dgw_search.Rows.Add()；被鼠标点击查询按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            // 先清空
            dgw_search.Rows.Clear();
            // 定义变量
            int index;
            string state = "已借出";
            string searchBy = "*";
            string sql;

            // 处理两个text内容（textbox里的不用处理）
            if (cbb_search.Text == "图书编号") searchBy = "bno";
            else if(cbb_search.Text == "图书名字") searchBy = "bname";
            else if (cbb_search.Text == "作者") searchBy = "author";
            else if (cbb_search.Text == "类型") searchBy = "b_type";
            else if (cbb_search.Text == "出版社") searchBy = "publisher";
            else searchBy = "bname";

            if (tb_search.Text == "")sql = "select * from book";
            else if (connectDB.SqlInject(tb_search.Text))
            {
                MessageBox.Show("你想干什么！？", "检测到sql注入");
                tb_search.Text = "";
                return;
            }
            else
                sql = "select * from book where " + searchBy + " like '%" + tb_search.Text + "%'";
            //System.Windows.Forms.MessageBox.Show(sql);

            // 连接数据库
            try
            {
                OdbcConnection con = new OdbcConnection(user.conString);
                con.Open();
             
                OdbcCommand com = new OdbcCommand(sql, con);
                OdbcDataReader reader = com.ExecuteReader();
                while(reader.Read())
                {
                    //System.Windows.Forms.MessageBox.Show(Convert.ToString(reader.FieldCount));
                    index = dgw_search.Rows.Add();
                    for (int i=0; i<reader.FieldCount; i++)
                    {// 填进去
                        if(i!=5)
                        {
                            if(i==6)
                            {
                                state = Convert.ToString(reader[i]) == "1" ? "已借出" : "可借";
                                dgw_search.Rows[index].Cells[5].Value = state;
                            }
                            else dgw_search.Rows[index].Cells[i].Value = Convert.ToString(reader[i]);
                        }
                    }
                }
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("请输入合法的搜索字符", "ERROR");
            }
            finally
            {
                ;
            }

        }

        /*************************************************************************
        【函数名称】       borrow_butt_Click
        【函数功能】       根据选择的图书进行借书操作，同时异常处理（未选择书本就点击、书已经被借走）
        【参数】           object sender, EventArgs e
        【访问变量】       选中的chosen_book_index行信息
        【返回值】         无
        【使用情况】       无调用函数；被鼠标点击选中借书按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void borrow_butt_Click(object sender, EventArgs e)
        {
            if(chosen_book_index < 0)
            {
                MessageBox.Show("请选择一本书先", "Error");
                return;
            }
            if(bookIsBorrowed)
            {
                MessageBox.Show("这本书被借走了，你再选一本吧", "You're Late!");
                return;
            }

            
            // 借书成功 1.在借书记录上添加相关借阅记录；2.把这本书的状态标记为已借出（及时更新）
            OdbcConnection con = new OdbcConnection(user.conString);
            con.Open();
            string sql1 = "insert into br_record(`uno`, `bno`, `b_date`) values(" + user.userId + ", " + bno + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            //MessageBox.Show(sql1);
            string sql2 = "update book set isBorrowed = 1 where bno = " + bno;
            OdbcCommand com1 = new OdbcCommand(sql1, con);
            com1.ExecuteNonQuery();
            OdbcCommand com2 = new OdbcCommand(sql2, con);
            com2.ExecuteNonQuery();

            MessageBox.Show("借书成功！\n 请再按一次搜索进行刷新操作", "消息");
            con.Close();
        }
    }
}
