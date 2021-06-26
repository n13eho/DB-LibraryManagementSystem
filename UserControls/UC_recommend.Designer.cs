namespace LibraryManagementSystem.UserControls
{
    partial class UC_recommend
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
            this.submit_butt = new System.Windows.Forms.Button();
            this.clear_butt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.tb_bookName = new System.Windows.Forms.TextBox();
            this.tb_publisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // submit_butt
            // 
            this.submit_butt.BackColor = System.Drawing.Color.ForestGreen;
            this.submit_butt.FlatAppearance.BorderSize = 0;
            this.submit_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_butt.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_butt.ForeColor = System.Drawing.Color.White;
            this.submit_butt.Location = new System.Drawing.Point(706, 475);
            this.submit_butt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submit_butt.Name = "submit_butt";
            this.submit_butt.Size = new System.Drawing.Size(181, 76);
            this.submit_butt.TabIndex = 8;
            this.submit_butt.Text = "提交";
            this.submit_butt.UseVisualStyleBackColor = false;
            this.submit_butt.Click += new System.EventHandler(this.submit_butt_Click);
            // 
            // clear_butt
            // 
            this.clear_butt.BackColor = System.Drawing.Color.Tomato;
            this.clear_butt.FlatAppearance.BorderSize = 0;
            this.clear_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_butt.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clear_butt.ForeColor = System.Drawing.Color.White;
            this.clear_butt.Location = new System.Drawing.Point(466, 475);
            this.clear_butt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clear_butt.Name = "clear_butt";
            this.clear_butt.Size = new System.Drawing.Size(187, 76);
            this.clear_butt.TabIndex = 8;
            this.clear_butt.Text = "重置";
            this.clear_butt.UseVisualStyleBackColor = false;
            this.clear_butt.Click += new System.EventHandler(this.clear_butt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(188, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "书名：";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tb_publisher);
            this.panel6.Controls.Add(this.tb_bookName);
            this.panel6.Controls.Add(this.tb_author);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.clear_butt);
            this.panel6.Controls.Add(this.submit_butt);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Font = new System.Drawing.Font("微软雅黑", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(985, 598);
            this.panel6.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(188, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "作者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(160, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "出版社：";
            // 
            // tb_author
            // 
            this.tb_author.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_author.Location = new System.Drawing.Point(310, 240);
            this.tb_author.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(514, 37);
            this.tb_author.TabIndex = 10;
            // 
            // tb_bookName
            // 
            this.tb_bookName.Location = new System.Drawing.Point(310, 151);
            this.tb_bookName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_bookName.Name = "tb_bookName";
            this.tb_bookName.Size = new System.Drawing.Size(514, 37);
            this.tb_bookName.TabIndex = 10;
            // 
            // tb_publisher
            // 
            this.tb_publisher.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_publisher.Location = new System.Drawing.Point(310, 330);
            this.tb_publisher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_publisher.Name = "tb_publisher";
            this.tb_publisher.Size = new System.Drawing.Size(514, 37);
            this.tb_publisher.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(39, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 50);
            this.label4.TabIndex = 9;
            this.label4.Text = "请输入你推荐的书目信息";
            // 
            // UC_recommend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_recommend";
            this.Size = new System.Drawing.Size(985, 598);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button submit_butt;
        private System.Windows.Forms.Button clear_butt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tb_publisher;
        private System.Windows.Forms.TextBox tb_bookName;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
