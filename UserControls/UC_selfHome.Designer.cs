namespace LibraryManagementSystem.UserControls
{
    partial class UC_selfHome
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_selfHome));
            this.label1 = new System.Windows.Forms.Label();
            this.refresh_btt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_borrowed_num = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDQYJ = new System.Windows.Forms.Button();
            this.history_br_num = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "借阅上限:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // refresh_btt
            // 
            this.refresh_btt.FlatAppearance.BorderSize = 0;
            this.refresh_btt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.refresh_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btt.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btt.Image")));
            this.refresh_btt.Location = new System.Drawing.Point(918, 0);
            this.refresh_btt.Name = "refresh_btt";
            this.refresh_btt.Size = new System.Drawing.Size(67, 61);
            this.refresh_btt.TabIndex = 1;
            this.refresh_btt.UseVisualStyleBackColor = true;
            this.refresh_btt.Click += new System.EventHandler(this.refresh_btt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(34, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 118);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "50";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_borrowed_num
            // 
            this.label_borrowed_num.AutoSize = true;
            this.label_borrowed_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_borrowed_num.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_borrowed_num.ForeColor = System.Drawing.Color.White;
            this.label_borrowed_num.Location = new System.Drawing.Point(415, 166);
            this.label_borrowed_num.Name = "label_borrowed_num";
            this.label_borrowed_num.Size = new System.Drawing.Size(51, 37);
            this.label_borrowed_num.TabIndex = 7;
            this.label_borrowed_num.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(371, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "当前已借：";
            // 
            // buttonDQYJ
            // 
            this.buttonDQYJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDQYJ.FlatAppearance.BorderSize = 0;
            this.buttonDQYJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDQYJ.Image = ((System.Drawing.Image)(resources.GetObject("buttonDQYJ.Image")));
            this.buttonDQYJ.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDQYJ.Location = new System.Drawing.Point(356, 105);
            this.buttonDQYJ.Name = "buttonDQYJ";
            this.buttonDQYJ.Size = new System.Drawing.Size(271, 118);
            this.buttonDQYJ.TabIndex = 6;
            this.buttonDQYJ.UseVisualStyleBackColor = false;
            this.buttonDQYJ.Click += new System.EventHandler(this.buttonDQYJ_Click);
            // 
            // history_br_num
            // 
            this.history_br_num.AutoSize = true;
            this.history_br_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.history_br_num.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_br_num.ForeColor = System.Drawing.Color.White;
            this.history_br_num.Location = new System.Drawing.Point(734, 166);
            this.history_br_num.Name = "history_br_num";
            this.history_br_num.Size = new System.Drawing.Size(51, 37);
            this.history_br_num.TabIndex = 10;
            this.history_br_num.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(694, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "历史借阅:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(679, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 118);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // UC_selfHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.history_br_num);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_borrowed_num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDQYJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refresh_btt);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_selfHome";
            this.Size = new System.Drawing.Size(985, 598);
            this.Load += new System.EventHandler(this.UC_selfHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refresh_btt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_borrowed_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDQYJ;
        private System.Windows.Forms.Label history_br_num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}
