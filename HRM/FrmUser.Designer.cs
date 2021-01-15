namespace HRM
{
    partial class FrmUser
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
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tspbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tspbtnQuit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblName = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(0, 25);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowTemplate.Height = 23;
            this.dgvUser.Size = new System.Drawing.Size(544, 264);
            this.dgvUser.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Account";
            this.Column2.HeaderText = "用户名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "RealName";
            this.Column3.HeaderText = "真实姓名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Name";
            this.Column4.HeaderText = "角色名称";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "IsActive";
            this.Column5.HeaderText = "是否启用";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "RoleID";
            this.Column6.HeaderText = "RoleID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspbtnAdd,
            this.tspbtnDelete,
            this.tspbtnEdit,
            this.tspbtnQuit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(544, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspbtnEdit
            // 
            this.tspbtnEdit.Image = global::HRM.Properties.Resources.edit;
            this.tspbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspbtnEdit.Name = "tspbtnEdit";
            this.tspbtnEdit.Size = new System.Drawing.Size(52, 22);
            this.tspbtnEdit.Text = "修改";
            this.tspbtnEdit.Click += new System.EventHandler(this.tspbtnEdit_Click);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 267);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(544, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblName
            // 
            this.tsslblName.Name = "tsslblName";
            this.tsslblName.Size = new System.Drawing.Size(56, 17);
            this.tsslblName.Text = "当前用户";
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 289);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmUser";
            this.Text = "人力资源管理系统—[用户管理]";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.ToolStripButton tspbtnAdd;
        private System.Windows.Forms.ToolStripButton tspbtnDelete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspbtnEdit;
        private System.Windows.Forms.ToolStripButton tspbtnQuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblName;
    }
}