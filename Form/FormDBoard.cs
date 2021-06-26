using LibraryManagementSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    /*************************************************************************
    【类名】             Form_addBook
    【功能】             系统使用主窗体
    【接口说明】          label1_Click(object sender, EventArgs e)、label1_Click(object sender, EventArgs e)、addControlsToPanel(Control c)、button1_Click(object sender, EventArgs e)、manageRecbooks_butt_Click(object sender, EventArgs e)、manageReader_butt_Click(object sender, EventArgs e)、manageBook_butt_Click(object sender, EventArgs e)、recommend_butt_Click(object sender, EventArgs e)、button1_Click_1(object sender, EventArgs e)、panelControl_Paint(object sender, PaintEventArgs e)、FormDBoard_MouseUp(object sender, MouseEventArgs e)、FormDBoard_MouseMove(object sender, MouseEventArgs e)、FormDBoard_MouseDown(object sender, MouseEventArgs e)、timerTime_Tick(object sender, EventArgs e)、button2_Click(object sender, EventArgs e)、label7_Click(object sender, EventArgs e)、moveSidePanel(Control btn)
    【开发者及日期】      Algernon, 2021/06/19
    【版本】             1.0
    *************************************************************************/
    public partial class FormDBoard : Form
    {
        private userInfo user;

        /***************************************************************
        【函数名称】         FormDBoard
        【函数功能】         构造函数、初始化窗体信息
        【参数】             输入参数：userInfo theUser
        【访问变量】         UC_selfHome
        【返回值】           无
        【使用情况】         调用InitializeComponent函数、addControlsToPanel函数、System.Windows.Forms.Timer::Start函数;被MainForm::buttonLogin_Click函数调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        public FormDBoard(userInfo theUser)
        {
            InitializeComponent();
            timerTime.Start();

            // 一开始就把个人中心的内容放在panelControl中去
            user = theUser;
            UC_selfHome ucsh = new UC_selfHome(theUser);
            addControlsToPanel(ucsh);

            // 一开始就显示出用户信息
            labelUserName.Text = theUser.userName;
            if (theUser.isManager)
                labelSF.Text = "管理员";
            else labelSF.Text = "普通用户";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /***************************************************************
        【函数名称】         addControlsToPanel
        【函数功能】         清空控制面板，重新加载新的面板
        【参数】             输入参数：Control c
        【访问变量】         DockStyle
        【返回值】           无
        【使用情况】         调用System.Windows.Forms.Panel.Controls::Clear、Add函数;被构造函数、button1_Click函数、button2_Click函数、button1_Click_1函数、recommend_butt_Click函数、manageBook_butt_Click函数、manageReader_butt_Click函数、manageRecbooks_butt_Click函数调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        /***************************************************************
        【函数名称】         button1_Click
        【函数功能】         显示个人中心界面
        【参数】             输入参数：object sender, EventArgs e
        【访问变量】         UC_selfHome
        【返回值】           无
        【使用情况】         调用moveSidePanel函数;被鼠标点击选中‘个人中心’按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(selfCenter);
            UC_selfHome ucsh = new UC_selfHome(user);
            addControlsToPanel(ucsh);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /***************************************************************
        【函数名称】         button7_Click
        【函数功能】         log out
        【参数】             输入参数：object sender, EventArgs e
        【访问变量】         无
        【返回值】           无
        【使用情况】         调用Hide函数、MainForm::ShowDialog函数、Close函数;被鼠标点击选中‘退出’按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/        
        private void button7_Click(object sender, EventArgs e)
        {//logout
            this.Hide();
            using (MainForm fd = new MainForm())
            {
                fd.ShowDialog();
            }
            this.Close();
        }

        /***************************************************************
        【函数名称】         quitButton_Click
        【函数功能】         退出窗口
        【参数】             输入参数：object sender, EventArgs e
        【访问变量】          无
        【返回值】           无
        【使用情况】         调用System.Windows.Forms.Timer::Start函数;被鼠标点击选中退出按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void quitButton_Click(object sender, EventArgs e)
        {
            timer_quit.Start();
        }

        /***************************************************************
        【函数名称】         timer_quit_Tick
        【函数功能】         
        【参数】             输入参数：object sender, EventArgs e
        【访问变量】         无
        【返回值】           无
        【使用情况】         调用System.Windows.Forms.Timer::Stop函数、Close函数;被鼠标点击选中xx按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void timer_quit_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.035)
                this.Opacity -= 0.035;
            else
            {
                timer_quit.Stop();
                this.Close();
            }
        }

        /***************************************************************
        【函数名称】         moveSidePanel
        【函数功能】         
        【参数】             输入参数：Control btn
        【访问变量】         无
        【返回值】           无
        【使用情况】         未调用函数;被button1_Click函数、button2_Click函数、button1_Click_1函数、recommend_butt_Click函数、manageBook_butt_Click函数、manageReader_butt_Click函数、manageRecbooks_butt_Click函数调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void moveSidePanel(Control btn)
        {
            sidePanle_pb.Top = btn.Top;
            sidePanle_pb.Height = btn.Height;
        }

        /***************************************************************
        【函数名称】         button2_Click
        【函数功能】         显示查询借阅界面
        【参数】             输入参数：object sender, EventArgs e
        【访问变量】         UC_lookPB
        【返回值】           无
        【使用情况】         调用moveSidePanel函数、addControlsToPanel函数;被鼠标点击选中‘查询借阅’按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void button2_Click(object sender, EventArgs e)
        {
            moveSidePanel(lookupBooks);
            UC_lookPB uclb = new UC_lookPB(user);
            addControlsToPanel(uclb);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        /***************************************************************
        【函数名称】         timerTime_Tick
        【函数功能】         
        【参数】             输入参数：object sender, EventArgs e
        【访问变量】         DateTime
        【返回值】           无
        【使用情况】         未调用函数;被鼠标点击选中xx按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            //dt = dt.AddMinutes(17);
            labelTime.Text = dt.ToString("HH:MM:ss");
            labelDate.Text = dt.ToString("D");
        }

        private bool formMove = false;//窗体是否移动
        private Point formPoint;//记录窗体未知

        /***************************************************************
        【函数名称】         FormDBoard_MouseDown
        【函数功能】         
        【参数】             输入参数：object sender, MouseEventArgs e
        【访问变量】         MouseButtons、SystemInformation
        【返回值】           无
        【使用情况】         调用函数、Close函数;被鼠标点击选中xx按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void FormDBoard_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint = new Point();
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
                formPoint = new Point(xOffset, yOffset);
                formMove = true;//开始移动
            }
        }

        /***************************************************************
        【函数名称】         FormDBoard_MouseMove
        【函数功能】         
        【参数】             输入参数：object sender, MouseEventArgs e
        【访问变量】         Control、formPoint
        【返回值】           无
        【使用情况】         未调用函数;被鼠标点击选中xx按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void FormDBoard_MouseMove(object sender, MouseEventArgs e)//鼠标移动
        {
            if (formMove == true)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                this.Location = mousePos;
            }
        }

        /***************************************************************
        【函数名称】         FormDBoard_MouseUp
        【函数功能】         
        【参数】            输入参数：object sender, MouseEventArgs e
        【访问变量】         MouseButtons
        【返回值】          无
        【使用情况】        未调用函数;被鼠标点击选中xx按钮动作所调用
        【开发者及日期】     Algernon, 2021/06/19
        【版本】            V1.0
        ****************************************************************/
        private void FormDBoard_MouseUp(object sender, MouseEventArgs e)//鼠标松开
        {
            if (e.Button == MouseButtons.Left)//按下的是鼠标左键
            {
                formMove = false;//停止移动
            }
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        /***************************************************************
        【函数名称】         button1_Click_1
        【函数功能】         显示还书界面
        【参数】             输入参数：object sender, EventArgs e
        【访问变量】         UC_returnBooks
        【返回值】           无
        【使用情况】         调用moveSidePanel函数、addControlsToPanel函数;被鼠标点击选中‘还书’按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void button1_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(returnBooks);
            UC_returnBooks ucrb = new UC_returnBooks(user);
            addControlsToPanel(ucrb);
        }

        /***************************************************************
        【函数名称】         recommend_butt_Click
        【函数功能】         显示推荐购买界面
        【参数】             输入参数：object sender, EventArgs e
        【访问变量】          recommend_butt
        【返回值】           无
        【使用情况】         调用moveSidePanel函数、addControlsToPanel函数;被鼠标点击选中‘推荐购买’按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void recommend_butt_Click(object sender, EventArgs e)
        {
            moveSidePanel(recommend_butt);
            UC_recommend ucrec = new UC_recommend(user);
            addControlsToPanel(ucrec);
        }

        /***************************************************************
        【函数名称】         manageBook_butt_Click
        【函数功能】         显示图书管理界面
        【参数】             输入参数：object sender, EventArgs e
        【访问变量】          manageBook_butt、user
        【返回值】           无
        【使用情况】         调用moveSidePanel函数、addControlsToPanel函数;被鼠标点击选中‘图书管理’按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void manageBook_butt_Click(object sender, EventArgs e)
        {
            if (user.isManager)
            {
                moveSidePanel(manageBook_butt);
                UCM_manageBooks i = new UCM_manageBooks(user);
                addControlsToPanel(i);
            }
            else
                MessageBox.Show("抱歉，该功能只针对管理员开放。", "Sorry");
        }

        /***************************************************************
        【函数名称】         manageReader_butt_Click
        【函数功能】         显示读者管理界面
        【参数】             输入参数：object sender, EventArgs e
        【访问变量】          manageReader_butt、user
        【返回值】           无
        【使用情况】         调用moveSidePanel函数、addControlsToPanel函数;被鼠标点击选中‘读者管理’按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void manageReader_butt_Click(object sender, EventArgs e)
        {
            if (user.isManager)
            {
                moveSidePanel(manageReader_butt);
                UCM_manageUsers i = new UCM_manageUsers(user);
                addControlsToPanel(i);
            }
            else
                MessageBox.Show("抱歉，该功能只针对管理员开放。", "Sorry");

        }

        /***************************************************************
        【函数名称】         manageRecbooks_butt_Click
        【函数功能】         显示查看已推荐界面
        【参数】             输入参数：object sender, EventArgs e
        【访问变量】          manageRecbooks_butt、user
        【返回值】           无
        【使用情况】         调用moveSidePanel函数、addControlsToPanel函数;被鼠标点击选中‘查看已推荐’按钮动作所调用
        【开发者及日期】      Algernon, 2021/06/19
        【版本】             V1.0
        ****************************************************************/
        private void manageRecbooks_butt_Click(object sender, EventArgs e)
        {
            //if (user.isManager)
            //{
                moveSidePanel(manageRecbooks_butt);
                UCM_manageRecomendedB i = new UCM_manageRecomendedB(user);
                addControlsToPanel(i);
            //}
            //else
            //    MessageBox.Show("抱歉，该功能只针对管理员开放。", "Sorry");
        }
    }
}
