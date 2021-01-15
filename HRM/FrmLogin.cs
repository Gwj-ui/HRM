using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ambow.HRM.BLL;
using Ambow.HRM.Model;

namespace HRM
{
    public partial class FrmLogin : Form
    {
        UserBLL ubll = new UserBLL();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                User u;
                try
                {
                    LoginResults choice = ubll.Login(txtName.Text.Trim(), txtPwd.Text.Trim(),out u);
                    if (choice==LoginResults.Success)
                    {
                        this.Visible = false;
                        FrmMain fm = new FrmMain(u);
                        fm.Show();
                    }
                    else if (choice==LoginResults.PwdError)
                    {
                        MessageBox.Show("密码错误");
                    }
                    else
                    {
                        MessageBox.Show("无效账号");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool ValidateInput()//有效性验证
        {
            if (txtName.Text.Trim()=="")
            {
                MessageBox.Show("请输入用户名");
                txtName.Focus();
                return false;
            }
            if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码");
                txtPwd.Focus();
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
