namespace HRM
{
    partial class FrmChangePwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtEditPwd = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPwdConfirm = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "初始密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(110, 108);
            this.txtPwd.MaxLength = 10;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(135, 21);
            this.txtPwd.TabIndex = 2;
            // 
            // txtEditPwd
            // 
            this.txtEditPwd.Location = new System.Drawing.Point(110, 150);
            this.txtEditPwd.MaxLength = 10;
            this.txtEditPwd.Name = "txtEditPwd";
            this.txtEditPwd.Size = new System.Drawing.Size(135, 21);
            this.txtEditPwd.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(91, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "修改密码";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(39, 69);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 12);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "当前用户";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "新密码确认：";
            // 
            // txtPwdConfirm
            // 
            this.txtPwdConfirm.Location = new System.Drawing.Point(110, 192);
            this.txtPwdConfirm.Name = "txtPwdConfirm";
            this.txtPwdConfirm.Size = new System.Drawing.Size(135, 21);
            this.txtPwdConfirm.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(179, 69);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 12);
            this.lblID.TabIndex = 10;
            this.lblID.Visible = false;
            // 
            // FrmChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 302);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtPwdConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEditPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FrmChangePwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtEditPwd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPwdConfirm;
        private System.Windows.Forms.Label lblID;
    }
}