namespace LibraryManagementSystem
{
    partial class Form_addBook
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
            this.label6 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.tb_pu = new System.Windows.Forms.TextBox();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.tb_bname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reset_butt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(250, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 50);
            this.label6.TabIndex = 1;
            this.label6.Text = "新增图书信息";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(498, 369);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(181, 56);
            this.submit.TabIndex = 11;
            this.submit.Text = "提交";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // tb_pu
            // 
            this.tb_pu.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pu.Location = new System.Drawing.Point(226, 229);
            this.tb_pu.Name = "tb_pu";
            this.tb_pu.Size = new System.Drawing.Size(348, 38);
            this.tb_pu.TabIndex = 8;
            // 
            // tb_author
            // 
            this.tb_author.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_author.Location = new System.Drawing.Point(226, 162);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(348, 38);
            this.tb_author.TabIndex = 9;
            // 
            // tb_bname
            // 
            this.tb_bname.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_bname.Location = new System.Drawing.Point(226, 94);
            this.tb_bname.Name = "tb_bname";
            this.tb_bname.Size = new System.Drawing.Size(348, 38);
            this.tb_bname.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(110, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "出版社：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(134, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "作者：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(86, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "图书名称：";
            // 
            // reset_butt
            // 
            this.reset_butt.BackColor = System.Drawing.Color.DarkGreen;
            this.reset_butt.FlatAppearance.BorderSize = 0;
            this.reset_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_butt.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reset_butt.ForeColor = System.Drawing.Color.White;
            this.reset_butt.Location = new System.Drawing.Point(311, 369);
            this.reset_butt.Name = "reset_butt";
            this.reset_butt.Size = new System.Drawing.Size(181, 56);
            this.reset_butt.TabIndex = 11;
            this.reset_butt.Text = "重置";
            this.reset_butt.UseVisualStyleBackColor = false;
            this.reset_butt.Click += new System.EventHandler(this.reset_butt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(134, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "分类：";
            // 
            // tb_type
            // 
            this.tb_type.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_type.Location = new System.Drawing.Point(226, 295);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(348, 38);
            this.tb_type.TabIndex = 9;
            // 
            // Form_addBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 458);
            this.Controls.Add(this.reset_butt);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.tb_pu);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.tb_author);
            this.Controls.Add(this.tb_bname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_addBook";
            this.Text = "Form_addBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox tb_pu;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.TextBox tb_bname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset_butt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_type;
    }
}