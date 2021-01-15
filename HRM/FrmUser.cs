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
    public partial class FrmUser : Form
    {
        UserBLL ubll = new UserBLL();
        User u;
        public FrmUser()
        {
            InitializeComponent();
        }

        public FrmUser(User u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void tspbtnAdd_Click(object sender, EventArgs e)
        {
            FrmUserAdd fua = new HRM.FrmUserAdd();
            if (fua.ShowDialog() == DialogResult.OK)
            {
                LoadAllUsers();
            }
        }

        private void tspbtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            LoadAllUsers();
            if (u!=null)
            {
                tsslblName.Text = "当前用户：" + u.RealName;
            }            
        }

        private void LoadAllUsers()//加载所有用户信息
        {
            try
            {
                dgvUser.AutoGenerateColumns = false;
                dgvUser.DataSource = ubll.GetAllUsers();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tspbtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUser.CurrentRow != null)
            {
                DataGridViewRow dgvr = dgvUser.CurrentRow;
                User u = new User();
                u.ID = (int)dgvr.Cells[0].Value;
                u.Account = dgvr.Cells[1].Value.ToString();
                u.RealName = dgvr.Cells[2].Value.ToString();
                u.RoleID = (int)dgvr.Cells[5].Value;
                u.IsActive = Convert.ToBoolean(dgvr.Cells[4].Value);
                FrmUserEdit fue = new HRM.FrmUserEdit(u);
                if (fue.ShowDialog() == DialogResult.OK)
                {
                    LoadAllUsers();
                }
            }
            else
            {
                MessageBox.Show("请先选中需要修改的行");
            }
        }

        private void tspbtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUser.CurrentRow != null)
            {
                DataGridViewRow dgvr = dgvUser.CurrentRow;
                int id = (int)dgvr.Cells[0].Value;
                string name = dgvr.Cells[1].Value.ToString();
                bool state = (bool)dgvr.Cells[4].Value;
                if (name == u.RealName)
                {
                    MessageBox.Show("不能删除当前登录用户");
                }
                else if (state)
                {
                    DialogResult choice1 = MessageBox.Show("该员工目前是在职状态，确认要删除选中用户【" + name + "】吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choice1 == DialogResult.Yes)
                    {
                        try
                        {
                            if (ubll.DeleteUser(id))
                            {
                                MessageBox.Show("删除成功");
                                LoadAllUsers();
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
                    DialogResult choice2 = MessageBox.Show("确认要删除选中用户【" + name + "】吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choice2 == DialogResult.Yes)
                    {
                        try
                        {
                            if (ubll.DeleteUser(id))
                            {
                                MessageBox.Show("删除成功");
                                LoadAllUsers();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选中需要删除的行");
            }
        }
    }
}
