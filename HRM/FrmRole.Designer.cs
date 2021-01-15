namespace HRM
{
    partial class FrmRole
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("所有角色");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("所有菜单");
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvwRole = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tspbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tspbtnQuit = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvwMenu = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRoleName = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.tvwRole);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 422);
            this.panel1.TabIndex = 0;
            // 
            // tvwRole
            // 
            this.tvwRole.ContextMenuStrip = this.contextMenuStrip1;
            this.tvwRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwRole.Location = new System.Drawing.Point(0, 25);
            this.tvwRole.Name = "tvwRole";
            treeNode1.Name = "root";
            treeNode1.Tag = "ID";
            treeNode1.Text = "所有角色";
            this.tvwRole.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvwRole.Size = new System.Drawing.Size(184, 397);
            this.tvwRole.TabIndex = 1;
            this.tvwRole.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwRole_AfterSelect);
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
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspbtnAdd,
            this.tspbtnDelete,
            this.tspbtnQuit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(184, 25);
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
            this.tspbtnQuit.BackColor = System.Drawing.SystemColors.Control;
            this.tspbtnQuit.Image = global::HRM.Properties.Resources.quit;
            this.tspbtnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspbtnQuit.Name = "tspbtnQuit";
            this.tspbtnQuit.Size = new System.Drawing.Size(52, 22);
            this.tspbtnQuit.Text = "退出";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtRoleName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 422);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tvwMenu);
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 299);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜单列表";
            // 
            // tvwMenu
            // 
            this.tvwMenu.CheckBoxes = true;
            this.tvwMenu.ContextMenuStrip = this.contextMenuStrip1;
            this.tvwMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwMenu.Location = new System.Drawing.Point(3, 17);
            this.tvwMenu.Name = "tvwMenu";
            treeNode2.Name = "root";
            treeNode2.Tag = "ID";
            treeNode2.Text = "所有菜单";
            this.tvwMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvwMenu.Size = new System.Drawing.Size(220, 279);
            this.tvwMenu.TabIndex = 0;
            this.tvwMenu.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwMenu_AfterCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "角色名称：";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(164, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(91, 22);
            this.txtRoleName.MaxLength = 20;
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(132, 21);
            this.txtRoleName.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(184, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 422);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // FrmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 422);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "角色管理";
            this.Load += new System.EventHandler(this.FrmRole_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspbtnAdd;
        private System.Windows.Forms.ToolStripButton tspbtnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvwMenu;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripButton tspbtnQuit;
        private System.Windows.Forms.TreeView tvwRole;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
    }
}