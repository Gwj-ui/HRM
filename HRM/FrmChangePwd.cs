using Ambow.HRM.BLL;
using Ambow.HRM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    public partial class FrmChangePwd : Form
    {
        UserBLL ubll = new UserBLL();
        User u;

        public FrmChangePwd()
        {
            InitializeComponent();
        }

        public FrmChangePwd(User u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void FrmChangePwd_Load(object sender, EventArgs e)
        {
            if (u != null)
            {
                lblUser.Text = u.RealName;
                lblID.Text = u.ID.ToString();
            }
        }

        private int LoginError = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (u != null)
            {
                if (ValidateInput())
                {
                    string pwd1 = txtPwd.Text.Trim();
                    string pwd2 = txtEditPwd.Text.Trim();
                    int id = Convert.ToInt32(lblID.Text.Trim());
                    try
                    {
                        if (pwd1 == u.Password)
                        {
                            if (ubll.ChangePwd(pwd2, id))
                            {
                                MessageBox.Show("修改成功,请重新登录");
                                Application.Restart();
                            }
                        }
                        else
                        {
                            MessageBox.Show("初始密码错误，请重新输入");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                LoginError++;
                if (LoginError>5)
                {
                    MessageBox.Show("操作频繁，请稍后再试");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInput()//有效性验证
        {
            if (txtEditPwd.Text.Trim() == "")
            {
                MessageBox.Show("请填写新密码");
                txtEditPwd.Focus();
                return false;
            }
            if (txtEditPwd.Text.Trim() == txtPwd.Text.Trim())
            {
                MessageBox.Show("新密码与旧密码不能相同");
                txtEditPwd.Focus();
                return false;
            }
            if (txtEditPwd.Text.Trim() != txtPwdConfirm.Text.Trim())
            {
                MessageBox.Show("两次密码输入不相同");
                txtPwdConfirm.Focus();
                return false;
            }
            if (txtEditPwd.Text.Trim().Length < 6 || txtEditPwd.Text.Trim().Length > 10)
            {
                MessageBox.Show("新密码位数应大于六小于十");
                txtEditPwd.Focus();
                return false;
            }
            return true;
        }

    }
}
