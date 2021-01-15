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
    public partial class FrmRole : Form
    {
        RoleBLL rbll = new RoleBLL();
        MenuBLL mbll = new MenuBLL();
        Operator op = Operator.Other;

        public FrmRole()
        {
            InitializeComponent();
        }

        private void FrmRole_Load(object sender, EventArgs e)
        {
            LoadAllRoles();
            LoadAllMenus();
            tvwMenu.Enabled = false;
        }

        private void LoadAllRoles()//加载下拉列表角色名称
        {
            try
            {
                List<Role> rolelist = rbll.GetAllRoles();
                TreeNode root = tvwRole.Nodes[0];
                root.Nodes.Clear();
                foreach (Role role in rolelist)
                {
                    TreeNode node = new TreeNode();
                    node.Text = role.Name;
                    node.Tag = role.ID;
                    root.Nodes.Add(node);
                }
                root.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAllMenus()//加载下拉列表菜单名称
        {
            try
            {
                List<Ambow.HRM.Model.Menu> menulist = mbll.GetAllMenus();
                TreeNode root = tvwMenu.Nodes[0];
                //    foreach (Ambow.HRM.Model.Menu menu in menulist)
                //    {
                //        if (menu.ParentID==0)
                //        {
                //            TreeNode node = new TreeNode();
                //            node.Text = menu.Text;
                //            node.Tag = menu.ID;
                //            root.Nodes.Add(node);
                //        }

                //    }
                foreach (Ambow.HRM.Model.Menu menu in menulist.Where(s => s.ParentID == 0))
                {
                    TreeNode node = new TreeNode();
                    node.Text = menu.Text;
                    node.Tag = menu.ID;
                    root.Nodes.Add(node);
                    foreach (Ambow.HRM.Model.Menu childMenu in menulist.Where(a => a.ParentID == menu.ID))
                    {
                        TreeNode childNode = new TreeNode();
                        childNode.Text = childMenu.Text;
                        childNode.Tag = childMenu.ID;
                        node.Nodes.Add(childNode);
                    }
                }
                root.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tspbtnAdd_Click(object sender, EventArgs e)
        {
            op = Operator.Add;
            tvwMenu.Enabled = true;
            txtRoleName.Text = "";
            ClearNodesChecked();
        }

        private void tspbtnDelete_Click(object sender, EventArgs e)
        {
            if (tvwRole.SelectedNode!=null&&tvwRole.SelectedNode.Name!="root")
            {
                string rolename = tvwRole.SelectedNode.Text;
                DialogResult choice = MessageBox.Show("确认删除选中角色【" + rolename + "】吗", "删除角色", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice==DialogResult.Yes)
                {
                    try
                    {
                        int roleid = (int)tvwRole.SelectedNode.Tag;
                        if (rbll.IsUse(roleid))
                        {
                            MessageBox.Show("该角色已经被使用，不能删除");
                            return;
                        }
                        int count = rbll.DeleteRole(roleid);
                        if (count>0)
                        {
                            MessageBox.Show("删除成功");
                            txtRoleName.Text = "";
                            op = Operator.Other;
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
                MessageBox.Show("请选择有效的节点");
            }
            tvwMenu.Enabled = false;
            LoadAllRoles();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string rolename = txtRoleName.Text.Trim();
                List<int> ids = new List<int>();
                TreeNode root = tvwMenu.Nodes[0];
                foreach (TreeNode node in root.Nodes)
                {
                    if (node.Checked)
                    {
                        ids.Add((int)node.Tag);
                        foreach (TreeNode childNode in node.Nodes)
                        {
                            if (childNode.Checked)
                            {
                                ids.Add((int)childNode.Tag);
                            }
                        }
                    }
                }
                if (op == Operator.Add)
                {
                    if (ids.Count > 0)
                    {
                        try
                        {
                            int count = rbll.AddRole(rolename, ids.ToArray());
                            if (count > 0)
                            {
                                MessageBox.Show("添加成功");
                                txtRoleName.Text = "";
                                LoadAllRoles();
                                tvwMenu.Enabled = false;
                                op = Operator.Other;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选择要添加的菜单权限");
                    }
                }
                else if (op == Operator.Edit)
                {
                    int roleid = (int)tvwRole.SelectedNode.Tag;
                    if (ids.Count>0)
                    {
                        try
                        {
                            int count = rbll.EditRole(roleid, rolename, ids.ToArray());
                            if (count>0)
                            {
                                MessageBox.Show("修改成功");
                                txtRoleName.Text = "";
                                LoadAllRoles();
                                tvwMenu.Enabled = false;
                                op = Operator.Other;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选择要修改的菜单权限");
                    }
                }
            }
        }            

        private void ClearNodesChecked()//清空菜单勾选
        {
            TreeNode root = tvwMenu.Nodes[0];
            root.Checked = false;
            foreach (TreeNode node in root.Nodes)
            {
                node.Checked = false;
                foreach (TreeNode childNode in node.Nodes)
                {
                    childNode.Checked = false;
                }
            }
        }

        private void SetSubNodeChecked(TreeNode node)
        {
            if (node.Checked == false)
            {
                if (node.Nodes.Count > 0)
                {
                    foreach (TreeNode childNode in node.Nodes)
                    {
                        childNode.Checked = false;
                        SetSubNodeChecked(childNode);
                    }
                }
            }
        }

        private void SetParentNodeChecked(TreeNode node)
        {
            if (node.Checked == true)
            {
                if (node.Parent != null)
                {
                    node.Parent.Checked = true;
                    SetParentNodeChecked(node.Parent);
                }
            }
        }

        private bool ValidateInput()//有效性验证
        {
            if (txtRoleName.Text.Trim() == null)
            {
                MessageBox.Show("请填写角色名称");
                txtRoleName.Focus();
                return false;
            }
            return true;
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (tvwRole.SelectedNode!=null&&tvwRole.SelectedNode.Name!="root")
            {
                op = Operator.Edit;
                tvwMenu.Enabled = true;
                txtRoleName.Text = tvwRole.SelectedNode.Text;
            }
            else
            {
                MessageBox.Show("请选择有效的节点");
            }           
        }

        private void tvwRole_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvwRole.SelectedNode != null)
            {
                if (tvwRole.SelectedNode.Name != "root")
                {
                    txtRoleName.Text = tvwRole.SelectedNode.Text;
                    int roleid = (int)tvwRole.SelectedNode.Tag;
                    try
                    {
                        List<Ambow.HRM.Model.Menu> rolemenus = mbll.GetMenusByRoleID(roleid);
                        TreeNode rootmenu = tvwMenu.Nodes[0];
                        rootmenu.Checked = true;
                        foreach (TreeNode node in rootmenu.Nodes)
                        {
                            node.Checked = rolemenus.FirstOrDefault(n => n.ID == (int)node.Tag) != null;
                            foreach (TreeNode childNode in node.Nodes)
                            {
                                childNode.Checked = rolemenus.FirstOrDefault(n => n.ID == (int)childNode.Tag) != null;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void tvwMenu_AfterCheck(object sender, TreeViewEventArgs e)
        {
            tvwMenu.AfterCheck -= tvwMenu_AfterCheck;
            SetSubNodeChecked(e.Node);
            SetParentNodeChecked(e.Node);
            tvwMenu.AfterCheck += tvwMenu_AfterCheck;
        }
    }
}
