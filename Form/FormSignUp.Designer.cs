namespace LibraryManagementSystem
{
    partial class FormSignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uname_tb = new System.Windows.Forms.TextBox();
            this.uno_tb = new System.Windows.Forms.TextBox();
            this.pass2_tb = new System.Windows.Forms.TextBox();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.signUp_butt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tele_tb = new System.Windows.Forms.TextBox();
            this.ugender_comb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(272, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(95, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "工号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(95, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "姓名：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(163, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "密码：";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(115, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "确认密码：";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // uname_tb
            // 
            this.uname_tb.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uname_tb.Location = new System.Drawing.Point(187, 170);
            this.uname_tb.Name = "uname_tb";
            this.uname_tb.Size = new System.Drawing.Size(163, 38);
            this.uname_tb.TabIndex = 1;
            // 
            // uno_tb
            // 
            this.uno_tb.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uno_tb.Location = new System.Drawing.Point(187, 106);
            this.uno_tb.Name = "uno_tb";
            this.uno_tb.Size = new System.Drawing.Size(163, 38);
            this.uno_tb.TabIndex = 1;
            // 
            // pass2_tb
            // 
            this.pass2_tb.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pass2_tb.Location = new System.Drawing.Point(255, 308);
            this.pass2_tb.Name = "pass2_tb";
            this.pass2_tb.Size = new System.Drawing.Size(294, 38);
            this.pass2_tb.TabIndex = 1;
            this.pass2_tb.UseSystemPasswordChar = true;
            // 
            // pass_tb
            // 
            this.pass_tb.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pass_tb.Location = new System.Drawing.Point(255, 244);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(294, 38);
            this.pass_tb.TabIndex = 1;
            this.pass_tb.UseSystemPasswordChar = true;
            // 
            // signUp_butt
            // 
            this.signUp_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signUp_butt.FlatAppearance.BorderSize = 0;
            this.signUp_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUp_butt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_butt.ForeColor = System.Drawing.Color.White;
            this.signUp_butt.Location = new System.Drawing.Point(136, 383);
            this.signUp_butt.Name = "signUp_butt";
            this.signUp_butt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.signUp_butt.Size = new System.Drawing.Size(472, 42);
            this.signUp_butt.TabIndex = 9;
            this.signUp_butt.Text = "Sign Up Now";
            this.signUp_butt.UseVisualStyleBackColor = false;
            this.signUp_butt.Click += new System.EventHandler(this.signUp_butt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(395, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "性别：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(395, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "电话：";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // tele_tb
            // 
            this.tele_tb.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tele_tb.Location = new System.Drawing.Point(487, 170);
            this.tele_tb.Name = "tele_tb";
            this.tele_tb.Size = new System.Drawing.Size(163, 38);
            this.tele_tb.TabIndex = 1;
            // 
            // ugender_comb
            // 
            this.ugender_comb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ugender_comb.Font = new System.Drawing.Font("微软雅黑", 13.8F);
            this.ugender_comb.FormattingEnabled = true;
            this.ugender_comb.Items.AddRange(new object[] {
            "男",
            "女"});
            this.ugender_comb.Location = new System.Drawing.Point(487, 106);
            this.ugender_comb.Name = "ugender_comb";
            this.ugender_comb.Size = new System.Drawing.Size(163, 38);
            this.ugender_comb.TabIndex = 10;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(744, 458);
            this.Controls.Add(this.ugender_comb);
            this.Controls.Add(this.signUp_butt);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.pass2_tb);
            this.Controls.Add(this.uno_tb);
            this.Controls.Add(this.tele_tb);
            this.Controls.Add(this.uname_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSignUp";
            this.Text = "FormSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uname_tb;
        private System.Windows.Forms.TextBox uno_tb;
        private System.Windows.Forms.TextBox pass2_tb;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.Button signUp_butt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tele_tb;
        private System.Windows.Forms.ComboBox ugender_comb;
    }
}