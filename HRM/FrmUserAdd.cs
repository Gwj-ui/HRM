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
    public partial class FrmUserAdd : Form
    {
        RoleBLL rbll = new RoleBLL();
        UserBLL ubll = new UserBLL();        
        public FrmUserAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                User u = new User();
                u.Account = txtUserName.Text.Trim();
                u.Password = txtPwd.Text.Trim();
                u.RealName = txtName.Text.Trim();
                u.RoleID = (int)cboRole.SelectedValue;
                u.IsActive = (bool)ckbIsActive.Checked;

                try
                {
                    int count = ubll.AddUser(u);
                    if (count>0)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("添加成功");                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            DisplayRole();
        }

        private void DisplayRole()//加载下拉列表的角色名称
        {
            try
            {
                cboRole.DataSource = rbll.GetAllRoles();
                cboRole.DisplayMember = "Name";
                cboRole.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateInput()//有效性验证
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("请填写用户名");
                txtUserName.Focus();
                return false;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("请填写密码");
                txtPwd.Focus();
                return false;
            }
            if (txtPwd.Text.Trim().Length < 6 || txtPwd.Text.Trim().Length > 10)
            {
                MessageBox.Show("新密码位数应大于六小于十");
                txtPwd.Focus();
                return false;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("请填写真实姓名");
                txtName.Focus();
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
