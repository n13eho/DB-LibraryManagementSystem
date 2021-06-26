namespace LibraryManagementSystem
{
    partial class FormDBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.manageRecbooks_butt = new System.Windows.Forms.Button();
            this.manageReader_butt = new System.Windows.Forms.Button();
            this.manageBook_butt = new System.Windows.Forms.Button();
            this.recommend_butt = new System.Windows.Forms.Button();
            this.returnBooks = new System.Windows.Forms.Button();
            this.lookupBooks = new System.Windows.Forms.Button();
            this.sidePanle_pb = new System.Windows.Forms.PictureBox();
            this.selfCenter = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSF = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer_quit = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidePanle_pb)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 122);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "图书管理系统";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.manageRecbooks_butt);
            this.panel2.Controls.Add(this.manageReader_butt);
            this.panel2.Controls.Add(this.manageBook_butt);
            this.panel2.Controls.Add(this.recommend_butt);
            this.panel2.Controls.Add(this.returnBooks);
            this.panel2.Controls.Add(this.lookupBooks);
            this.panel2.Controls.Add(this.sidePanle_pb);
            this.panel2.Controls.Add(this.selfCenter);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 720);
            this.panel2.TabIndex = 0;
            // 
            // manageRecbooks_butt
            // 
            this.manageRecbooks_butt.FlatAppearance.BorderSize = 0;
            this.manageRecbooks_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageRecbooks_butt.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageRecbooks_butt.ForeColor = System.Drawing.Color.White;
            this.manageRecbooks_butt.Image = ((System.Drawing.Image)(resources.GetObject("manageRecbooks_butt.Image")));
            this.manageRecbooks_butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageRecbooks_butt.Location = new System.Drawing.Point(14, 560);
            this.manageRecbooks_butt.Name = "manageRecbooks_butt";
            this.manageRecbooks_butt.Size = new System.Drawing.Size(201, 68);
            this.manageRecbooks_butt.TabIndex = 10;
            this.manageRecbooks_butt.Text = " 查看已推荐";
            this.manageRecbooks_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageRecbooks_butt.UseVisualStyleBackColor = true;
            this.manageRecbooks_butt.Click += new System.EventHandler(this.manageRecbooks_butt_Click);
            // 
            // manageReader_butt
            // 
            this.manageReader_butt.FlatAppearance.BorderSize = 0;
            this.manageReader_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageReader_butt.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageReader_butt.ForeColor = System.Drawing.Color.White;
            this.manageReader_butt.Image = ((System.Drawing.Image)(resources.GetObject("manageReader_butt.Image")));
            this.manageReader_butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageReader_butt.Location = new System.Drawing.Point(14, 486);
            this.manageReader_butt.Name = "manageReader_butt";
            this.manageReader_butt.Size = new System.Drawing.Size(201, 68);
            this.manageReader_butt.TabIndex = 9;
            this.manageReader_butt.Text = "  读者管理";
            this.manageReader_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageReader_butt.UseVisualStyleBackColor = true;
            this.manageReader_butt.Click += new System.EventHandler(this.manageReader_butt_Click);
            // 
            // manageBook_butt
            // 
            this.manageBook_butt.FlatAppearance.BorderSize = 0;
            this.manageBook_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBook_butt.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBook_butt.ForeColor = System.Drawing.Color.White;
            this.manageBook_butt.Image = ((System.Drawing.Image)(resources.GetObject("manageBook_butt.Image")));
            this.manageBook_butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageBook_butt.Location = new System.Drawing.Point(14, 414);
            this.manageBook_butt.Name = "manageBook_butt";
            this.manageBook_butt.Size = new System.Drawing.Size(201, 68);
            this.manageBook_butt.TabIndex = 8;
            this.manageBook_butt.Text = "  图书管理";
            this.manageBook_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageBook_butt.UseVisualStyleBackColor = true;
            this.manageBook_butt.Click += new System.EventHandler(this.manageBook_butt_Click);
            // 
            // recommend_butt
            // 
            this.recommend_butt.FlatAppearance.BorderSize = 0;
            this.recommend_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recommend_butt.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommend_butt.ForeColor = System.Drawing.Color.White;
            this.recommend_butt.Image = ((System.Drawing.Image)(resources.GetObject("recommend_butt.Image")));
            this.recommend_butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recommend_butt.Location = new System.Drawing.Point(14, 340);
            this.recommend_butt.Name = "recommend_butt";
            this.recommend_butt.Size = new System.Drawing.Size(201, 68);
            this.recommend_butt.TabIndex = 7;
            this.recommend_butt.Text = "  推荐购买";
            this.recommend_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.recommend_butt.UseVisualStyleBackColor = true;
            this.recommend_butt.Click += new System.EventHandler(this.recommend_butt_Click);
            // 
            // returnBooks
            // 
            this.returnBooks.FlatAppearance.BorderSize = 0;
            this.returnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBooks.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks.ForeColor = System.Drawing.Color.White;
            this.returnBooks.Image = ((System.Drawing.Image)(resources.GetObject("returnBooks.Image")));
            this.returnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBooks.Location = new System.Drawing.Point(14, 266);
            this.returnBooks.Name = "returnBooks";
            this.returnBooks.Size = new System.Drawing.Size(201, 68);
            this.returnBooks.TabIndex = 6;
            this.returnBooks.Text = "      还书";
            this.returnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.returnBooks.UseVisualStyleBackColor = true;
            this.returnBooks.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lookupBooks
            // 
            this.lookupBooks.FlatAppearance.BorderSize = 0;
            this.lookupBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lookupBooks.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupBooks.ForeColor = System.Drawing.Color.White;
            this.lookupBooks.Image = ((System.Drawing.Image)(resources.GetObject("lookupBooks.Image")));
            this.lookupBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lookupBooks.Location = new System.Drawing.Point(14, 194);
            this.lookupBooks.Name = "lookupBooks";
            this.lookupBooks.Size = new System.Drawing.Size(201, 68);
            this.lookupBooks.TabIndex = 5;
            this.lookupBooks.Text = "  查询借阅";
            this.lookupBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lookupBooks.UseVisualStyleBackColor = true;
            this.lookupBooks.Click += new System.EventHandler(this.button2_Click);
            // 
            // sidePanle_pb
            // 
            this.sidePanle_pb.BackColor = System.Drawing.Color.White;
            this.sidePanle_pb.Location = new System.Drawing.Point(0, 123);
            this.sidePanle_pb.Name = "sidePanle_pb";
            this.sidePanle_pb.Size = new System.Drawing.Size(12, 68);
            this.sidePanle_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sidePanle_pb.TabIndex = 4;
            this.sidePanle_pb.TabStop = false;
            // 
            // selfCenter
            // 
            this.selfCenter.FlatAppearance.BorderSize = 0;
            this.selfCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selfCenter.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selfCenter.ForeColor = System.Drawing.Color.White;
            this.selfCenter.Image = ((System.Drawing.Image)(resources.GetObject("selfCenter.Image")));
            this.selfCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selfCenter.Location = new System.Drawing.Point(12, 124);
            this.selfCenter.Name = "selfCenter";
            this.selfCenter.Size = new System.Drawing.Size(201, 68);
            this.selfCenter.TabIndex = 3;
            this.selfCenter.Text = "  个人中心";
            this.selfCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selfCenter.UseVisualStyleBackColor = true;
            this.selfCenter.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.logout);
            this.panelTitle.Controls.Add(this.quitButton);
            this.panelTitle.Controls.Add(this.label2);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(215, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(985, 48);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDBoard_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDBoard_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormDBoard_MouseUp);
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(880, -1);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(53, 48);
            this.logout.TabIndex = 3;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.button7_Click);
            // 
            // quitButton
            // 
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Image = ((System.Drawing.Image)(resources.GetObject("quitButton.Image")));
            this.quitButton.Location = new System.Drawing.Point(932, 0);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(53, 47);
            this.quitButton.TabIndex = 3;
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "图书管理系统 by tqy，version 1.0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.labelTime);
            this.panel4.Controls.Add(this.labelDate);
            this.panel4.Controls.Add(this.labelSF);
            this.panel4.Controls.Add(this.labelUserName);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(215, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(985, 74);
            this.panel4.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(876, 40);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(98, 23);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "HH:MM:SS";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(842, 11);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(121, 23);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "2000年9月9日";
            this.labelDate.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelSF
            // 
            this.labelSF.AutoSize = true;
            this.labelSF.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSF.ForeColor = System.Drawing.Color.White;
            this.labelSF.Location = new System.Drawing.Point(107, 40);
            this.labelSF.Name = "labelSF";
            this.labelSF.Size = new System.Drawing.Size(69, 25);
            this.labelSF.TabIndex = 7;
            this.labelSF.Text = "管理员";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(107, 9);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(69, 25);
            this.labelUserName.TabIndex = 6;
            this.labelUserName.Text = "我是谁";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "身份：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "欢迎！";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer_quit
            // 
            this.timer_quit.Interval = 15;
            this.timer_quit.Tick += new System.EventHandler(this.timer_quit_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(215, 122);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(985, 598);
            this.panelControl.TabIndex = 3;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // FormDBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDBoard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sidePanle_pb)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button selfCenter;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox sidePanle_pb;
        private System.Windows.Forms.Button lookupBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSF;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer_quit;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button returnBooks;
        private System.Windows.Forms.Button recommend_butt;
        private System.Windows.Forms.Button manageRecbooks_butt;
        private System.Windows.Forms.Button manageReader_butt;
        private System.Windows.Forms.Button manageBook_butt;
        private System.Windows.Forms.Button logout;
    }
}