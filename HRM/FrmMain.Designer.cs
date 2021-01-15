namespace HRM
{
    partial class FrmMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRights = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHRM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDept = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSex = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDegree = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblName = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.SystemColors.Control;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystem,
            this.tsmiRights,
            this.tsmiHRM,
            this.tsmiReport,
            this.tsmiWindow});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(958, 25);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // tsmiSystem
            // 
            this.tsmiSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangePwd,
            this.tsmiLogout,
            this.tsmiExit});
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.Size = new System.Drawing.Size(59, 21);
            this.tsmiSystem.Text = "系统(S)";
            // 
            // tsmiChangePwd
            // 
            this.tsmiChangePwd.Name = "tsmiChangePwd";
            this.tsmiChangePwd.Size = new System.Drawing.Size(124, 22);
            this.tsmiChangePwd.Text = "修改密码";
            this.tsmiChangePwd.Click += new System.EventHandler(this.tsmiChangePwd_Click);
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(124, 22);
            this.tsmiLogout.Text = "退出登录";
            this.tsmiLogout.Click += new System.EventHandler(this.tsmiLogout_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(124, 22);
            this.tsmiExit.Text = "退出系统";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiRights
            // 
            this.tsmiRights.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoles,
            this.tsmiUsers});
            this.tsmiRights.Name = "tsmiRights";
            this.tsmiRights.Size = new System.Drawing.Size(83, 21);
            this.tsmiRights.Text = "权限管理(P)";
            // 
            // tsmiRoles
            // 
            this.tsmiRoles.Name = "tsmiRoles";
            this.tsmiRoles.Size = new System.Drawing.Size(124, 22);
            this.tsmiRoles.Text = "角色管理";
            this.tsmiRoles.Click += new System.EventHandler(this.tsmiRoles_Click);
            // 
            // tsmiUsers
            // 
            this.tsmiUsers.Name = "tsmiUsers";
            this.tsmiUsers.Size = new System.Drawing.Size(124, 22);
            this.tsmiUsers.Text = "用户管理";
            this.tsmiUsers.Click += new System.EventHandler(this.tsmiUsers_Click);
            // 
            // tsmiHRM
            // 
            this.tsmiHRM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDept,
            this.tsmiEmployee});
            this.tsmiHRM.Name = "tsmiHRM";
            this.tsmiHRM.Size = new System.Drawing.Size(85, 21);
            this.tsmiHRM.Text = "人事管理(H)";
            // 
            // tsmiDept
            // 
            this.tsmiDept.Name = "tsmiDept";
            this.tsmiDept.Size = new System.Drawing.Size(124, 22);
            this.tsmiDept.Text = "部门管理";
            this.tsmiDept.Click += new System.EventHandler(this.tsmiDept_Click);
            // 
            // tsmiEmployee
            // 
            this.tsmiEmployee.Name = "tsmiEmployee";
            this.tsmiEmployee.Size = new System.Drawing.Size(124, 22);
            this.tsmiEmployee.Text = "员工管理";
            this.tsmiEmployee.Click += new System.EventHandler(this.tsmiEmployee_Click);
            // 
            // tsmiReport
            // 
            this.tsmiReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSex,
            this.tsmiDegree});
            this.tsmiReport.Name = "tsmiReport";
            this.tsmiReport.Size = new System.Drawing.Size(84, 21);
            this.tsmiReport.Text = "统计报表(R)";
            // 
            // tsmiSex
            // 
            this.tsmiSex.Name = "tsmiSex";
            this.tsmiSex.Size = new System.Drawing.Size(136, 22);
            this.tsmiSex.Text = "按性别统计";
            this.tsmiSex.Click += new System.EventHandler(this.tsmiSex_Click);
            // 
            // tsmiDegree
            // 
            this.tsmiDegree.Name = "tsmiDegree";
            this.tsmiDegree.Size = new System.Drawing.Size(136, 22);
            this.tsmiDegree.Text = "按学历统计";
            this.tsmiDegree.Click += new System.EventHandler(this.tsmiDegree_Click);
            // 
            // tsmiWindow
            // 
            this.tsmiWindow.Name = "tsmiWindow";
            this.tsmiWindow.Size = new System.Drawing.Size(64, 21);
            this.tsmiWindow.Text = "窗口(W)";
            this.tsmiWindow.Click += new System.EventHandler(this.tsmiWindow_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(958, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblName
            // 
            this.tsslblName.Name = "tsslblName";
            this.tsslblName.Size = new System.Drawing.Size(56, 17);
            this.tsslblName.Text = "当前用户";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(958, 516);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FrmMain";
            this.Text = "人力资源管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePwd;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiRights;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoles;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiHRM;
        private System.Windows.Forms.ToolStripMenuItem tsmiDept;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiSex;
        private System.Windows.Forms.ToolStripMenuItem tsmiDegree;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblName;
    }
}

