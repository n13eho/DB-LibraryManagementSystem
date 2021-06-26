namespace LibraryManagementSystem.UserControls
{
    partial class UC_lookPB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_lookPB));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgw_search = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.borrow_butt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.cbb_search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_search)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 12);
            this.panel2.TabIndex = 11;
            // 
            // dgw_search
            // 
            this.dgw_search.AllowUserToAddRows = false;
            this.dgw_search.AllowUserToDeleteRows = false;
            this.dgw_search.AllowUserToResizeRows = false;
            this.dgw_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgw_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgw_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_search.Location = new System.Drawing.Point(0, 0);
            this.dgw_search.Name = "dgw_search";
            this.dgw_search.ReadOnly = true;
            this.dgw_search.RowHeadersVisible = false;
            this.dgw_search.RowHeadersWidth = 51;
            this.dgw_search.RowTemplate.Height = 27;
            this.dgw_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_search.Size = new System.Drawing.Size(957, 508);
            this.dgw_search.TabIndex = 0;
            this.dgw_search.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Column4.HeaderText = "类型";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "出版社";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "状态";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 586);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(14, 586);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 12);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(971, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 574);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.borrow_butt);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.tb_search);
            this.panel5.Controls.Add(this.cbb_search);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(14, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(957, 66);
            this.panel5.TabIndex = 14;
            // 
            // borrow_butt
            // 
            this.borrow_butt.BackColor = System.Drawing.Color.ForestGreen;
            this.borrow_butt.FlatAppearance.BorderSize = 0;
            this.borrow_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrow_butt.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow_butt.ForeColor = System.Drawing.Color.White;
            this.borrow_butt.Location = new System.Drawing.Point(710, 8);
            this.borrow_butt.Name = "borrow_butt";
            this.borrow_butt.Size = new System.Drawing.Size(127, 48);
            this.borrow_butt.TabIndex = 8;
            this.borrow_butt.Text = "选中借书";
            this.borrow_butt.UseVisualStyleBackColor = false;
            this.borrow_butt.Click += new System.EventHandler(this.borrow_butt_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(579, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 54);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.White;
            this.tb_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(363, 15);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(210, 32);
            this.tb_search.TabIndex = 6;
            // 
            // cbb_search
            // 
            this.cbb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_search.FormattingEnabled = true;
            this.cbb_search.Items.AddRange(new object[] {
            "图书编号",
            "图书名字",
            "作者",
            "类型",
            "出版社"});
            this.cbb_search.Location = new System.Drawing.Point(236, 16);
            this.cbb_search.Name = "cbb_search";
            this.cbb_search.Size = new System.Drawing.Size(121, 31);
            this.cbb_search.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgw_search);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(14, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(957, 508);
            this.panel6.TabIndex = 16;
            // 
            // UC_lookPB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_lookPB";
            this.Size = new System.Drawing.Size(985, 598);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_search)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgw_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button borrow_butt;
    }
}
