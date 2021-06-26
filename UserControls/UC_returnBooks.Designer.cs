namespace LibraryManagementSystem.UserControls
{
    partial class UC_returnBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_returnBooks));
            this.panel5 = new System.Windows.Forms.Panel();
            this.return_butt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgv_mybook = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mybook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.return_butt);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(14, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(957, 66);
            this.panel5.TabIndex = 19;
            // 
            // return_butt
            // 
            this.return_butt.BackColor = System.Drawing.Color.Orange;
            this.return_butt.FlatAppearance.BorderSize = 0;
            this.return_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_butt.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_butt.ForeColor = System.Drawing.Color.White;
            this.return_butt.Location = new System.Drawing.Point(620, 9);
            this.return_butt.Name = "return_butt";
            this.return_butt.Size = new System.Drawing.Size(127, 48);
            this.return_butt.TabIndex = 8;
            this.return_butt.Text = "选中还书";
            this.return_butt.UseVisualStyleBackColor = false;
            this.return_butt.Click += new System.EventHandler(this.return_butt_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(776, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 54);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "我已借阅的书";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(971, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 569);
            this.panel4.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(14, 584);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 14);
            this.panel3.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 583);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 15);
            this.panel2.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgv_mybook);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(14, 81);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(957, 503);
            this.panel6.TabIndex = 20;
            // 
            // dgv_mybook
            // 
            this.dgv_mybook.AllowUserToAddRows = false;
            this.dgv_mybook.AllowUserToDeleteRows = false;
            this.dgv_mybook.AllowUserToResizeRows = false;
            this.dgv_mybook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mybook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgv_mybook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mybook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_mybook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_mybook.Location = new System.Drawing.Point(0, 0);
            this.dgv_mybook.Name = "dgv_mybook";
            this.dgv_mybook.RowHeadersVisible = false;
            this.dgv_mybook.RowHeadersWidth = 51;
            this.dgv_mybook.RowTemplate.Height = 27;
            this.dgv_mybook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mybook.Size = new System.Drawing.Size(957, 503);
            this.dgv_mybook.TabIndex = 0;
            this.dgv_mybook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mybook_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "图书编号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "图书名称";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "作者";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "借书日期";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // UC_returnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_returnBooks";
            this.Size = new System.Drawing.Size(985, 598);
            this.Load += new System.EventHandler(this.UC_returnBooks_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mybook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button return_butt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgv_mybook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
