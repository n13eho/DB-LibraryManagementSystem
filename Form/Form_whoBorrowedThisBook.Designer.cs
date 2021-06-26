namespace LibraryManagementSystem
{
    partial class Form_whoBorrowedThisBook
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
            this.submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bname_tb = new System.Windows.Forms.Label();
            this.uname_tb = new System.Windows.Forms.Label();
            this.uno_tb = new System.Windows.Forms.Label();
            this.date_tb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(523, 375);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(181, 56);
            this.submit.TabIndex = 17;
            this.submit.Text = "ok";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(181, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "借书日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(181, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "当前读者号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(181, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "当前读者姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(181, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "图书名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(240, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 50);
            this.label6.TabIndex = 12;
            this.label6.Text = "新增图书信息";
            // 
            // bname_tb
            // 
            this.bname_tb.AutoSize = true;
            this.bname_tb.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bname_tb.Location = new System.Drawing.Point(370, 104);
            this.bname_tb.Name = "bname_tb";
            this.bname_tb.Size = new System.Drawing.Size(110, 31);
            this.bname_tb.TabIndex = 16;
            this.bname_tb.Text = "图书名称";
            this.bname_tb.Click += new System.EventHandler(this.label5_Click);
            // 
            // uname_tb
            // 
            this.uname_tb.AutoSize = true;
            this.uname_tb.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uname_tb.Location = new System.Drawing.Point(370, 172);
            this.uname_tb.Name = "uname_tb";
            this.uname_tb.Size = new System.Drawing.Size(110, 31);
            this.uname_tb.TabIndex = 15;
            this.uname_tb.Text = "读者姓名";
            // 
            // uno_tb
            // 
            this.uno_tb.AutoSize = true;
            this.uno_tb.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uno_tb.Location = new System.Drawing.Point(370, 239);
            this.uno_tb.Name = "uno_tb";
            this.uno_tb.Size = new System.Drawing.Size(86, 31);
            this.uno_tb.TabIndex = 13;
            this.uno_tb.Text = "读者号";
            // 
            // date_tb
            // 
            this.date_tb.AutoSize = true;
            this.date_tb.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date_tb.Location = new System.Drawing.Point(370, 305);
            this.date_tb.Name = "date_tb";
            this.date_tb.Size = new System.Drawing.Size(62, 31);
            this.date_tb.TabIndex = 14;
            this.date_tb.Text = "日期";
            // 
            // Form_whoBorrowedThisBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 458);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.date_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uno_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uname_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bname_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_whoBorrowedThisBook";
            this.Text = "Form_whoBorrowedThisBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bname_tb;
        private System.Windows.Forms.Label uname_tb;
        private System.Windows.Forms.Label uno_tb;
        private System.Windows.Forms.Label date_tb;
    }
}