namespace LibraryManagementSystem.UserControls
{
    partial class UCM_manageBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCM_manageBooks));
            this.panel5 = new System.Windows.Forms.Panel();
            this.refreash_butt = new System.Windows.Forms.Button();
            this.addBooks_butt = new System.Windows.Forms.Button();
            this.delete_butt = new System.Windows.Forms.Button();
            this.update_butt = new System.Windows.Forms.Button();
            this.ssearch_butt = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.cbb_search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_manageBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manageBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.refreash_butt);
            this.panel5.Controls.Add(this.addBooks_butt);
            this.panel5.Controls.Add(this.delete_butt);
            this.panel5.Controls.Add(this.update_butt);
            this.panel5.Controls.Add(this.ssearch_butt);
            this.panel5.Controls.Add(this.tb_search);
            this.panel5.Controls.Add(this.cbb_search);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(14, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(957, 66);
            this.panel5.TabIndex = 19;
            // 
            // refreash_butt
            // 
            this.refreash_butt.FlatAppearance.BorderSize = 0;
            this.refreash_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreash_butt.Image = ((System.Drawing.Image)(resources.GetObject("refreash_butt.Image")));
            this.refreash_butt.Location = new System.Drawing.Point(478, 6);
            this.refreash_butt.Name = "refreash_butt";
            this.refreash_butt.Size = new System.Drawing.Size(54, 54);
            this.refreash_butt.TabIndex = 9;
            this.refreash_butt.UseVisualStyleBackColor = true;
            this.refreash_butt.Click += new System.EventHandler(this.refreash_butt_Click);
            // 
            // addBooks_butt
            // 
            this.addBooks_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addBooks_butt.FlatAppearance.BorderSize = 0;
            this.addBooks_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_butt.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_butt.ForeColor = System.Drawing.Color.White;
            this.addBooks_butt.Location = new System.Drawing.Point(811, 9);
            this.addBooks_butt.Name = "addBooks_butt";
            this.addBooks_butt.Size = new System.Drawing.Size(127, 48);
            this.addBooks_butt.TabIndex = 8;
            this.addBooks_butt.Text = "新增图书";
            this.addBooks_butt.UseVisualStyleBackColor = false;
            this.addBooks_butt.Click += new System.EventHandler(this.addBooks_butt_Click);
            // 
            // delete_butt
            // 
            this.delete_butt.BackColor = System.Drawing.Color.Red;
            this.delete_butt.FlatAppearance.BorderSize = 0;
            this.delete_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_butt.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_butt.ForeColor = System.Drawing.Color.White;
            this.delete_butt.Location = new System.Drawing.Point(678, 9);
            this.delete_butt.Name = "delete_butt";
            this.delete_butt.Size = new System.Drawing.Size(127, 48);
            this.delete_butt.TabIndex = 8;
            this.delete_butt.Text = "选中删除";
            this.delete_butt.UseVisualStyleBackColor = false;
            this.delete_butt.Click += new System.EventHandler(this.delete_butt_Click);
            // 
            // update_butt
            // 
            this.update_butt.BackColor = System.Drawing.Color.ForestGreen;
            this.update_butt.FlatAppearance.BorderSize = 0;
            this.update_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_butt.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_butt.ForeColor = System.Drawing.Color.White;
            this.update_butt.Location = new System.Drawing.Point(545, 9);
            this.update_butt.Name = "update_butt";
            this.update_butt.Size = new System.Drawing.Size(127, 48);
            this.update_butt.TabIndex = 8;
            this.update_butt.Text = "选中修改";
            this.update_butt.UseVisualStyleBackColor = false;
            this.update_butt.Click += new System.EventHandler(this.update_butt_Click);
            // 
            // ssearch_butt
            // 
            this.ssearch_butt.FlatAppearance.BorderSize = 0;
            this.ssearch_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ssearch_butt.Image = ((System.Drawing.Image)(resources.GetObject("ssearch_butt.Image")));
            this.ssearch_butt.Location = new System.Drawing.Point(418, 6);
            this.ssearch_butt.Name = "ssearch_butt";
            this.ssearch_butt.Size = new System.Drawing.Size(54, 54);
            this.ssearch_butt.TabIndex = 7;
            this.ssearch_butt.UseVisualStyleBackColor = true;
            this.ssearch_butt.Click += new System.EventHandler(this.ssearch_butt_Click);
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.White;
            this.tb_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(257, 17);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(155, 32);
            this.tb_search.TabIndex = 6;
            // 
            // cbb_search
            // 
            this.cbb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_search.FormattingEnabled = true;
            this.cbb_search.Items.AddRange(new object[] {
            "图书编号",
            "图书名字",
            "作者"});
            this.cbb_search.Location = new System.Drawing.Point(130, 18);
            this.cbb_search.Name = "cbb_search";
            this.cbb_search.Size = new System.Drawing.Size(121, 31);
            this.cbb_search.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By:";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(971, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 574);
            this.panel4.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(14, 586);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 12);
            this.panel3.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 586);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 12);
            this.panel2.TabIndex = 15;
            // 
            // dgv_manageBooks
            // 
            this.dgv_manageBooks.AllowUserToAddRows = false;
            this.dgv_manageBooks.AllowUserToDeleteRows = false;
            this.dgv_manageBooks.AllowUserToResizeRows = false;
            this.dgv_manageBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_manageBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgv_manageBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manageBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7});
            this.dgv_manageBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_manageBooks.Location = new System.Drawing.Point(14, 78);
            this.dgv_manageBooks.Name = "dgv_manageBooks";
            this.dgv_manageBooks.ReadOnly = true;
            this.dgv_manageBooks.RowHeadersVisible = false;
            this.dgv_manageBooks.RowHeadersWidth = 51;
            this.dgv_manageBooks.RowTemplate.Height = 27;
            this.dgv_manageBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_manageBooks.Size = new System.Drawing.Size(957, 508);
            this.dgv_manageBooks.TabIndex = 20;
            this.dgv_manageBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_manageBooks_CellClick);
            this.dgv_manageBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_manageBooks_CellDoubleClick);
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
            // Column7
            // 
            this.Column7.HeaderText = "是否借出";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // UCM_manageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_manageBooks);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCM_manageBooks";
            this.Size = new System.Drawing.Size(985, 598);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manageBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button addBooks_butt;
        private System.Windows.Forms.Button delete_butt;
        private System.Windows.Forms.Button update_butt;
        private System.Windows.Forms.Button ssearch_butt;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ComboBox cbb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_manageBooks;
        private System.Windows.Forms.Button refreash_butt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
