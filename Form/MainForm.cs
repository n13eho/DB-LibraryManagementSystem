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
    【类名】             MainForm
    【功能】             登录、注册主窗口
    【接口说明】          login_pb_Click(object sender, EventArgs e)、quitTimer_Tick(object sender, EventArgs e)、label2_Click(object sender, EventArgs e)、loginPanelTop_MouseUp(object sender, MouseEventArgs e)、signUp_Click(object sender, EventArgs e)、signUp_Click(object sender, EventArgs e)、buttonLogin_Click(object sender, EventArgs e)
    【开发者及日期】      Algernon, 2021/06/19
    【版本】             1.0
    *************************************************************************/
    public partial class MainForm : Form
    {

        /*************************************************************************
        【函数名称】       MainForm
        【函数功能】       类构造函数
        【参数】           无
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用InitializeComponent()；被主函数Program.cs调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
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

        /*************************************************************************
        【函数名称】       signUp_Click
        【函数功能】       新用户注册
        【参数】           object sender, EventArgs e
        【访问变量】       无
        【返回值】         无
        【使用情况】       调用fd.ShowDialog()函数；被鼠标点击‘Sign Up’按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
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

        /*************************************************************************
        【函数名称】       buttonLogin_Click
        【函数功能】       用户登录
        【参数】           object sender, EventArgs e
        【访问变量】       theUser
        【返回值】         无
        【使用情况】       调用fd.ShowDialog()函数；被鼠标点击‘Sign in’按钮动作所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
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

        /*************************************************************************
        【函数名称】       loginPanelTop_MouseDown
        【函数功能】       移动窗体-鼠标按下
        【参数】           object sender, MouseEventArgs e
        【访问变量】       无
        【返回值】         无
        【使用情况】       无调用函数；被鼠标按在窗体head所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
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


        /*************************************************************************
        【函数名称】       loginPanelTop_MouseDown
        【函数功能】       移动窗体-鼠标按下后移动
        【参数】           object sender, MouseEventArgs e
        【访问变量】       无
        【返回值】         无
        【使用情况】       无调用函数；被鼠标按在窗体head所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
        private void loginPanelTop_MouseMove(object sender, MouseEventArgs e)//鼠标移动
        {
            if (formMove == true)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                this.Location = mousePos;
            }
        }

        /*************************************************************************
        【函数名称】       loginPanelTop_MouseDown
        【函数功能】       移动窗体-鼠标按下后移动后松开
        【参数】           object sender, MouseEventArgs e
        【访问变量】       无
        【返回值】         无
        【使用情况】       无调用函数；被鼠标按在窗体head所调用
        【开发者及日期】    Algernon, 2021/06/19
        【版本】           V1.0
        *************************************************************************/
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
