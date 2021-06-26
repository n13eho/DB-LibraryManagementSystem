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

        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

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

        private void button7_Click(object sender, EventArgs e)
        {//logout
            this.Hide();
            using (MainForm fd = new MainForm())
            {
                fd.ShowDialog();
            }
            this.Close();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            timer_quit.Start();
        }

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


        private void moveSidePanel(Control btn)
        {
            sidePanle_pb.Top = btn.Top;
            sidePanle_pb.Height = btn.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveSidePanel(lookupBooks);
            UC_lookPB uclb = new UC_lookPB(user);
            addControlsToPanel(uclb);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            //dt = dt.AddMinutes(17);
            labelTime.Text = dt.ToString("HH:MM:ss");
            labelDate.Text = dt.ToString("D");
        }

        private bool formMove = false;//窗体是否移动
        private Point formPoint;//记录窗体未知
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

        private void FormDBoard_MouseMove(object sender, MouseEventArgs e)//鼠标移动
        {
            if (formMove == true)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                this.Location = mousePos;
            }
        }

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(returnBooks);
            UC_returnBooks ucrb = new UC_returnBooks(user);
            addControlsToPanel(ucrb);
        }

        private void recommend_butt_Click(object sender, EventArgs e)
        {
            moveSidePanel(recommend_butt);
            UC_recommend ucrec = new UC_recommend(user);
            addControlsToPanel(ucrec);
        }

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
