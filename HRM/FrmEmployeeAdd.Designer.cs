namespace HRM
{
    partial class FrmEmployeeAdd
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
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.cboNation = new System.Windows.Forms.ComboBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.cboDegree = new System.Windows.Forms.ComboBox();
            this.cboPolity = new System.Windows.Forms.ComboBox();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(122, 355);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(337, 82);
            this.txtMemo.TabIndex = 58;
            // 
            // txtResume
            // 
            this.txtResume.Location = new System.Drawing.Point(122, 245);
            this.txtResume.Multiline = true;
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(337, 82);
            this.txtResume.TabIndex = 57;
            // 
            // cboNation
            // 
            this.cboNation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNation.FormattingEnabled = true;
            this.cboNation.Items.AddRange(new object[] {
            "汉族",
            "回族",
            "蒙古族",
            "藏族",
            "维吾尔族",
            "苗族",
            "朝鲜族"});
            this.cboNation.Location = new System.Drawing.Point(338, 158);
            this.cboNation.Name = "cboNation";
            this.cboNation.Size = new System.Drawing.Size(121, 20);
            this.cboNation.TabIndex = 56;
            // 
            // cboPosition
            // 
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Items.AddRange(new object[] {
            "总经理",
            "经理",
            "组长",
            "职员"});
            this.cboPosition.Location = new System.Drawing.Point(338, 72);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(121, 20);
            this.cboPosition.TabIndex = 55;
            // 
            // cboDegree
            // 
            this.cboDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDegree.FormattingEnabled = true;
            this.cboDegree.Items.AddRange(new object[] {
            "本科",
            "硕士",
            "博士",
            "专科"});
            this.cboDegree.Location = new System.Drawing.Point(122, 201);
            this.cboDegree.Name = "cboDegree";
            this.cboDegree.Size = new System.Drawing.Size(121, 20);
            this.cboDegree.TabIndex = 54;
            // 
            // cboPolity
            // 
            this.cboPolity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPolity.FormattingEnabled = true;
            this.cboPolity.Items.AddRange(new object[] {
            "党员",
            "团员",
            "群众",
            "民主人士"});
            this.cboPolity.Location = new System.Drawing.Point(122, 158);
            this.cboPolity.Name = "cboPolity";
            this.cboPolity.Size = new System.Drawing.Size(121, 20);
            this.cboPolity.TabIndex = 53;
            // 
            // cboDept
            // 
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(122, 72);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(121, 20);
            this.cboDept.TabIndex = 52;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(338, 115);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(121, 21);
            this.txtPhone.TabIndex = 51;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(338, 201);
            this.txtSalary.MaxLength = 10;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(121, 21);
            this.txtSalary.TabIndex = 50;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 115);
            this.txtEmail.MaxLength = 20;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 21);
            this.txtEmail.TabIndex = 32;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 26);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 21);
            this.txtName.TabIndex = 33;
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.Checked = true;
            this.ckbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbStatus.Location = new System.Drawing.Point(405, 30);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(72, 16);
            this.ckbStatus.TabIndex = 49;
            this.ckbStatus.Text = "是否在职";
            this.ckbStatus.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(364, 30);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 48;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(323, 30);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 47;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(75, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 46;
            this.label12.Text = "备注：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 45;
            this.label11.Text = "个人履历：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 44;
            this.label10.Text = "月薪：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 43;
            this.label9.Text = "学历：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 42;
            this.label8.Text = "民族：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 41;
            this.label7.Text = "政治面貌：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 40;
            this.label6.Text = "电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "Email：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 38;
            this.label4.Text = "职位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "部门：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "姓名：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(384, 467);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmEmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 516);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtResume);
            this.Controls.Add(this.cboNation);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.cboDegree);
            this.Controls.Add(this.cboPolity);
            this.Controls.Add(this.cboDept);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ckbStatus);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmployeeAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加员工";
            this.Load += new System.EventHandler(this.FrmEmployeeAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.TextBox txtResume;
        private System.Windows.Forms.ComboBox cboNation;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.ComboBox cboDegree;
        private System.Windows.Forms.ComboBox cboPolity;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox ckbStatus;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}