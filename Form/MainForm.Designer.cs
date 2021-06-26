namespace LibraryManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.loginPanelTop = new System.Windows.Forms.Panel();
            this.quitButt = new System.Windows.Forms.Button();
            this.login_pb = new System.Windows.Forms.PictureBox();
            this.loginTitleName = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.quitTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tb_userId = new System.Windows.Forms.TextBox();
            this.passw = new System.Windows.Forms.Label();
            this.tb_userPass = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.ForgetPassword = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanelTop
            // 
            this.loginPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.loginPanelTop.Controls.Add(this.quitButt);
            this.loginPanelTop.Controls.Add(this.login_pb);
            this.loginPanelTop.Controls.Add(this.loginTitleName);
            this.loginPanelTop.Controls.Add(this.ForgetPassword);
            this.loginPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginPanelTop.Location = new System.Drawing.Point(0, 0);
            this.loginPanelTop.Name = "loginPanelTop";
            this.loginPanelTop.Size = new System.Drawing.Size(1200, 57);
            this.loginPanelTop.TabIndex = 0;
            this.loginPanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginPanelTop_MouseDown);
            this.loginPanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginPanelTop_MouseMove);
            this.loginPanelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginPanelTop_MouseUp);
            // 
            // quitButt
            // 
            this.quitButt.FlatAppearance.BorderSize = 0;
            this.quitButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.quitButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButt.Image = ((System.Drawing.Image)(resources.GetObject("quitButt.Image")));
            this.quitButt.Location = new System.Drawing.Point(1139, 0);
            this.quitButt.Name = "quitButt";
            this.quitButt.Size = new System.Drawing.Size(61, 57);
            this.quitButt.TabIndex = 9;
            this.quitButt.UseVisualStyleBackColor = true;
            this.quitButt.Click += new System.EventHandler(this.quitButt_Click);
            // 
            // login_pb
            // 
            this.login_pb.Enabled = false;
            this.login_pb.Image = ((System.Drawing.Image)(resources.GetObject("login_pb.Image")));
            this.login_pb.Location = new System.Drawing.Point(14, 3);
            this.login_pb.Name = "login_pb";
            this.login_pb.Size = new System.Drawing.Size(55, 51);
            this.login_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_pb.TabIndex = 2;
            this.login_pb.TabStop = false;
            this.login_pb.Click += new System.EventHandler(this.login_pb_Click);
            // 
            // loginTitleName
            // 
            this.loginTitleName.AutoSize = true;
            this.loginTitleName.Font = new System.Drawing.Font("微软雅黑", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginTitleName.ForeColor = System.Drawing.Color.White;
            this.loginTitleName.Location = new System.Drawing.Point(72, 4);
            this.loginTitleName.Name = "loginTitleName";
            this.loginTitleName.Size = new System.Drawing.Size(218, 44);
            this.loginTitleName.TabIndex = 2;
            this.loginTitleName.Text = "图书管理系统";
            this.loginTitleName.Click += new System.EventHandler(this.loginTitleName_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.userName.Location = new System.Drawing.Point(360, 296);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(81, 23);
            this.userName.TabIndex = 1;
            this.userName.Text = "User ID:";
            // 
            // quitTimer
            // 
            this.quitTimer.Interval = 15;
            this.quitTimer.Tick += new System.EventHandler(this.quitTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(445, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please Login First";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_userId
            // 
            this.tb_userId.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_userId.Location = new System.Drawing.Point(364, 332);
            this.tb_userId.Name = "tb_userId";
            this.tb_userId.Size = new System.Drawing.Size(472, 36);
            this.tb_userId.TabIndex = 5;
            // 
            // passw
            // 
            this.passw.AutoSize = true;
            this.passw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.passw.Location = new System.Drawing.Point(360, 381);
            this.passw.Name = "passw";
            this.passw.Size = new System.Drawing.Size(108, 23);
            this.passw.TabIndex = 1;
            this.passw.Text = "Password:";
            // 
            // tb_userPass
            // 
            this.tb_userPass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_userPass.Location = new System.Drawing.Point(364, 417);
            this.tb_userPass.Name = "tb_userPass";
            this.tb_userPass.Size = new System.Drawing.Size(472, 36);
            this.tb_userPass.TabIndex = 5;
            this.tb_userPass.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(364, 536);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(472, 42);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // ForgetPassword
            // 
            this.ForgetPassword.AutoSize = true;
            this.ForgetPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.ForgetPassword.Location = new System.Drawing.Point(865, 17);
            this.ForgetPassword.Name = "ForgetPassword";
            this.ForgetPassword.Size = new System.Drawing.Size(178, 23);
            this.ForgetPassword.TabIndex = 7;
            this.ForgetPassword.Text = "Forget Password?";
            this.ForgetPassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.signUp.FlatAppearance.BorderSize = 0;
            this.signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUp.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.ForeColor = System.Drawing.Color.White;
            this.signUp.Location = new System.Drawing.Point(364, 612);
            this.signUp.Name = "signUp";
            this.signUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.signUp.Size = new System.Drawing.Size(472, 42);
            this.signUp.TabIndex = 8;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.tb_userPass);
            this.Controls.Add(this.tb_userId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.loginPanelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.loginPanelTop.ResumeLayout(false);
            this.loginPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginPanelTop;
        private System.Windows.Forms.Label loginTitleName;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox login_pb;
        private System.Windows.Forms.Timer quitTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_userId;
        private System.Windows.Forms.Label passw;
        private System.Windows.Forms.TextBox tb_userPass;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label ForgetPassword;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button quitButt;
    }
}

