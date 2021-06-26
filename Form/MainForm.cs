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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void login_pb_Click(object sender, EventArgs e)
        {
            
        }

        private void quitTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.025)
                this.Opacity -= 0.025;
            else
            {
                quitTimer.Stop();
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signUp_Click(object sender, EventArgs e)
        {
            using (FormSignUp fd = new FormSignUp())
            {
                fd.ShowDialog();
            }
        }

        private void loginTitleName_Click(object sender, EventArgs e)
        {

        }

        private void quitButt_Click(object sender, EventArgs e)
        {
            quitTimer.Start();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // 创建一个用户示例
            userInfo theUser = new userInfo(tb_userId.Text, tb_userPass.Text);

            if (theUser.isValid) // isValid
            {
                if(theUser.isIllegal)
                {// 合法性检查通过了
                    this.Hide();
                    using (FormDBoard fd = new FormDBoard(theUser))
                    {
                        fd.ShowDialog();
                    }
                    this.Dispose();
                }
                else
                    MessageBox.Show("抱歉，你的账户存在违规违法现象，请联系管理员解除", "非法用户");
            }
            else if(!theUser.havewarn)
            {
                MessageBox.Show("用户名或密码不正确", "ERROR");
                theUser.havewarn = false;
            }
        }

        private bool formMove = false;//窗体是否移动
        private Point formPoint;//记录窗体未知
        private void loginPanelTop_MouseDown(object sender, MouseEventArgs e)
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

        private void loginPanelTop_MouseMove(object sender, MouseEventArgs e)//鼠标移动
        {
            if (formMove == true)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                this.Location = mousePos;
            }
        }

        private void loginPanelTop_MouseUp(object sender, MouseEventArgs e)//鼠标松开
        {
            if (e.Button == MouseButtons.Left)//按下的是鼠标左键
            {
                formMove = false;//停止移动
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
