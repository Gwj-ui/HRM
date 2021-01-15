namespace HRM
{
    partial class FrmDept
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvwDept = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tspbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tspbtnQuit = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblParentName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tvwDept);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 400);
            this.panel1.TabIndex = 0;
            // 
            // tvwDept
            // 
            this.tvwDept.ContextMenuStrip = this.contextMenuStrip1;
            this.tvwDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwDept.Location = new System.Drawing.Point(0, 25);
            this.tvwDept.Name = "tvwDept";
            this.tvwDept.Size = new System.Drawing.Size(189, 375);
            this.tvwDept.TabIndex = 1;
            this.tvwDept.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwDept_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(100, 22);
            this.tsmiEdit.Text = "修改";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspbtnAdd,
            this.tspbtnDelete,
            this.tspbtnQuit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(189, 25);
            this.toolStrip1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(189, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 400);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblParentName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDeptName);
            this.groupBox1.Location = new System.Drawing.Point(16, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "浏览/修改部门信息";
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(19, 31);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(65, 12);
            this.lblParentName.TabIndex = 3;
            this.lblParentName.Text = "父部门名称";
            this.lblParentName.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(133, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "部门名称：";
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(90, 70);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.ReadOnly = true;
            this.txtDeptName.Size = new System.Drawing.Size(118, 21);
            this.txtDeptName.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(189, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 400);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // FrmDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 400);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDept";
            this.Text = "部门管理";
            this.Load += new System.EventHandler(this.FrmDept_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvwDept;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspbtnAdd;
        private System.Windows.Forms.ToolStripButton tspbtnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripButton tspbtnQuit;
        private System.Windows.Forms.Label lblParentName;
    }
}