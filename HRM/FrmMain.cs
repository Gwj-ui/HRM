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
using Ambow.HRM.BLL;

namespace HRM
{
    public partial class FrmMain : Form
    {
        User u;
        MenuBLL mbll = new MenuBLL();

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(User u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void tsmiChangePwd_Click(object sender, EventArgs e)
        {
            if (u!=null)
            {
                u.RealName = tsslblName.Text.Trim();
                FrmChangePwd fcp = new HRM.FrmChangePwd(u);
                fcp.ShowDialog();
            }
        }

        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("确定要退出当前账号吗？", "退出登录", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (choice == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("当前身份已过期，请重新登录");
                this.Close();
                FrmLogin fl = new FrmLogin();
                fl.Show();
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("确定要退出本系统吗？", "退出系统", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (choice == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tsmiRoles_Click(object sender, EventArgs e)
        {
            FrmRole fr = new HRM.FrmRole();
            fr.MdiParent = this;
            fr.Show();
        }

        private void tsmiUsers_Click(object sender, EventArgs e)
        {
            FrmUser fu = new HRM.FrmUser(u);
            fu.MdiParent = this;
            fu.Show();
        }

        private void tsmiDept_Click(object sender, EventArgs e)
        {
            FrmDept fd = new FrmDept();
            fd.MdiParent = this;
            fd.Show();
        }

        private void tsmiEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee fep = new FrmEmployee();
            fep.MdiParent = this;
            fep.Show();
        }

        private void tsmiWindow_Click(object sender, EventArgs e)
        {

        }

        private void tsmiSex_Click(object sender, EventArgs e)
        {
            FrmSexReport fsr = new FrmSexReport();
            fsr.ShowDialog();
        }

        private void tsmiDegree_Click(object sender, EventArgs e)
        {
            FrmDegreeReport fdr = new HRM.FrmDegreeReport();
            fdr.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (u!=null)
            {
                tsslblName.Text = "当前用户：" + u.RealName;
            }
            HideMenuItems();
            try
            {
                List<Ambow.HRM.Model.Menu> menulist = mbll.GetMenusByRoleID(u.RoleID);
                foreach (ToolStripMenuItem  tsmi in mnuMain.Items)
                {
                    if (menulist.FirstOrDefault(m=>m.Name==tsmi.Name)!=null)
                    {
                        tsmi.Visible = true;
                        foreach (ToolStripMenuItem childtsmi in tsmi.DropDownItems)
                        {
                            if (menulist.FirstOrDefault(m => m.Name == childtsmi.Name) != null)
                            {
                                childtsmi.Visible = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HideMenuItems()//隐藏菜单栏
        {
            foreach (ToolStripMenuItem tsmi in mnuMain.Items)
            {
                tsmi.Visible = false;
                if (tsmi.DropDownItems.Count>0)
                {
                    foreach (ToolStripMenuItem childtsmi in tsmi.DropDownItems)
                    {
                        childtsmi.Visible = false;
                    }
                }
            }
        }

    }
}
