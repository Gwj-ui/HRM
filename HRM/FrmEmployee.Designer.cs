namespace HRM
{
    partial class FrmEmployee
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tspbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tspbtnQuit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspbtnAdd,
            this.tspbtnDelete,
            this.tspbtnQuit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(846, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspbtnAdd
            // 
            this.tspbtnAdd.Image = global::HRM.Properties.Resources.add;
            this.tspbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspbtnAdd.Name = "tspbtnAdd";
            this.tspbtnAdd.Size = new System.Drawing.Size(52, 22);
            this.tspbtnAdd.Text = "添加";
            this.tspbtnAdd.Click += new System.EventHandler(this.tspbtnAdd_Click);
            // 
            // tspbtnDelete
            // 
            this.tspbtnDelete.Image = global::HRM.Properties.Resources.delete;
            this.tspbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspbtnDelete.Name = "tspbtnDelete";
            this.tspbtnDelete.Size = new System.Drawing.Size(52, 22);
            this.tspbtnDelete.Text = "删除";
            this.tspbtnDelete.Click += new System.EventHandler(this.tspbtnDelete_Click);
            // 
            // tspbtnQuit
            // 
            this.tspbtnQuit.Image = global::HRM.Properties.Resources.quit;
            this.tspbtnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspbtnQuit.Name = "tspbtnQuit";
            this.tspbtnQuit.Size = new System.Drawing.Size(52, 22);
            this.tspbtnQuit.Text = "退出";
            this.tspbtnQuit.Click += new System.EventHandler(this.tspbtnQuit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 72);
            this.panel1.TabIndex = 8;
            // 
            // txtEName
            // 
            this.txtEName.Location = new System.Drawing.Point(206, 25);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(133, 21);
            this.txtEName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "员工姓名：";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(361, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column10,
            this.Column5,
            this.Column13,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column11,
            this.Column12,
            this.Column14,
            this.Column15});
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 97);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowTemplate.Height = 23;
            this.dgvEmployee.Size = new System.Drawing.Size(846, 244);
            this.dgvEmployee.TabIndex = 9;
            this.dgvEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellDoubleClick);
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "EID";
            this.Column9.HeaderText = "序号";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EName";
            this.Column1.HeaderText = "姓名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Sex";
            this.Column2.HeaderText = "性别";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DName";
            this.Column3.HeaderText = "部门";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Position";
            this.Column4.HeaderText = "职务";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Salary";
            this.Column10.HeaderText = "月薪";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Phone";
            this.Column5.HeaderText = "联系电话";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Email";
            this.Column13.HeaderText = "邮箱";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Degree";
            this.Column6.HeaderText = "学历";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Status";
            this.Column7.HeaderText = "是否在职";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DepartmentID";
            this.Column8.HeaderText = "部门编号";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Resume";
            this.Column11.HeaderText = "个人履历";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Memo";
            this.Column12.HeaderText = "备注";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "Polity";
            this.Column14.HeaderText = "政治面貌";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Nation";
            this.Column15.HeaderText = "民族";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 341);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmEmployee";
            this.Text = "人力资源管理系统—[员工管理]";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspbtnAdd;
        private System.Windows.Forms.ToolStripButton tspbtnDelete;
        private System.Windows.Forms.ToolStripButton tspbtnQuit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}