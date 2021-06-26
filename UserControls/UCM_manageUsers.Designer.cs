namespace LibraryManagementSystem.UserControls
{
    partial class UCM_manageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCM_manageUsers));
            this.panel5 = new System.Windows.Forms.Panel();
            this.refreash_butt = new System.Windows.Forms.Button();
            this.delete_butt = new System.Windows.Forms.Button();
            this.ssearch_butt = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.cbb_search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.illegal_butt = new System.Windows.Forms.Button();
            this.dgv_manageUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manageUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.refreash_butt);
            this.panel5.Controls.Add(this.illegal_butt);
            this.panel5.Controls.Add(this.delete_butt);
            this.panel5.Controls.Add(this.ssearch_butt);
            this.panel5.Controls.Add(this.tb_search);
            this.panel5.Controls.Add(this.cbb_search);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(14, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(957, 66);
            this.panel5.TabIndex = 24;
            // 
            // refreash_butt
            // 
            this.refreash_butt.FlatAppearance.BorderSize = 0;
            this.refreash_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreash_butt.Image = ((System.Drawing.Image)(resources.GetObject("refreash_butt.Image")));
            this.refreash_butt.Location = new System.Drawing.Point(527, 6);
            this.refreash_butt.Name = "refreash_butt";
            this.refreash_butt.Size = new System.Drawing.Size(54, 54);
            this.refreash_butt.TabIndex = 9;
            this.refreash_butt.UseVisualStyleBackColor = true;
            this.refreash_butt.Click += new System.EventHandler(this.refreash_butt_Click);
            // 
            // delete_butt
            // 
            this.delete_butt.BackColor = System.Drawing.Color.Red;
            this.delete_butt.FlatAppearance.BorderSize = 0;
            this.delete_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_butt.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_butt.ForeColor = System.Drawing.Color.White;
            this.delete_butt.Location = new System.Drawing.Point(807, 9);
            this.delete_butt.Name = "delete_butt";
            this.delete_butt.Size = new System.Drawing.Size(127, 48);
            this.delete_butt.TabIndex = 8;
            this.delete_butt.Text = "选中删除";
            this.delete_butt.UseVisualStyleBackColor = false;
            this.delete_butt.Click += new System.EventHandler(this.delete_butt_Click);
            // 
            // ssearch_butt
            // 
            this.ssearch_butt.FlatAppearance.BorderSize = 0;
            this.ssearch_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ssearch_butt.Image = ((System.Drawing.Image)(resources.GetObject("ssearch_butt.Image")));
            this.ssearch_butt.Location = new System.Drawing.Point(467, 6);
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
            this.tb_search.Location = new System.Drawing.Point(306, 17);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(155, 32);
            this.tb_search.TabIndex = 6;
            // 
            // cbb_search
            // 
            this.cbb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_search.FormattingEnabled = true;
            this.cbb_search.Items.AddRange(new object[] {
            "工号",
            "姓名"});
            this.cbb_search.Location = new System.Drawing.Point(179, 18);
            this.cbb_search.Name = "cbb_search";
            this.cbb_search.Size = new System.Drawing.Size(121, 31);
            this.cbb_search.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 22);
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
            this.panel4.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(14, 586);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 12);
            this.panel3.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 586);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 12);
            this.panel2.TabIndex = 20;
            // 
            // illegal_butt
            // 
            this.illegal_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.illegal_butt.FlatAppearance.BorderSize = 0;
            this.illegal_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.illegal_butt.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illegal_butt.ForeColor = System.Drawing.Color.White;
            this.illegal_butt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.illegal_butt.Location = new System.Drawing.Point(606, 9);
            this.illegal_butt.Name = "illegal_butt";
            this.illegal_butt.Size = new System.Drawing.Size(195, 48);
            this.illegal_butt.TabIndex = 8;
            this.illegal_butt.Text = "更改身份合法性";
            this.illegal_butt.UseVisualStyleBackColor = false;
            this.illegal_butt.Click += new System.EventHandler(this.illegal_butt_Click);
            // 
            // dgv_manageUsers
            // 
            this.dgv_manageUsers.AllowUserToAddRows = false;
            this.dgv_manageUsers.AllowUserToDeleteRows = false;
            this.dgv_manageUsers.AllowUserToResizeRows = false;
            this.dgv_manageUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_manageUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgv_manageUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manageUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_manageUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_manageUsers.Location = new System.Drawing.Point(14, 78);
            this.dgv_manageUsers.Name = "dgv_manageUsers";
            this.dgv_manageUsers.ReadOnly = true;
            this.dgv_manageUsers.RowHeadersVisible = false;
            this.dgv_manageUsers.RowHeadersWidth = 51;
            this.dgv_manageUsers.RowTemplate.Height = 27;
            this.dgv_manageUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_manageUsers.Size = new System.Drawing.Size(957, 508);
            this.dgv_manageUsers.TabIndex = 25;
            this.dgv_manageUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_manageUsers_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "工号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "姓名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "电话";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "身份是否合法";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // UCM_manageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_manageUsers);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCM_manageUsers";
            this.Size = new System.Drawing.Size(985, 598);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manageUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button refreash_butt;
        private System.Windows.Forms.Button illegal_butt;
        private System.Windows.Forms.Button delete_butt;
        private System.Windows.Forms.Button ssearch_butt;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ComboBox cbb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_manageUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
