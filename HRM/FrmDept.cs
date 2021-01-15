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
    public partial class FrmDept : Form
    {
        DeptBLL dbll = new DeptBLL();
        Operator op = Operator.Other;
        Department dept = new Department();

        public FrmDept()
        {
            InitializeComponent();
        }

        private void FrmDept_Load(object sender, EventArgs e)
        {
            LoadAllDept();
        }

        private void LoadAllDept()//加载第一层节点
        {
            tvwDept.Nodes.Clear();
            try
            {
                List<Department> deptlist = dbll.GetAllDepartment();
                foreach (Department dept in deptlist.Where(d => d.ParentID == 0))
                {
                    TreeNode root = new TreeNode(dept.Name);
                    root.Tag = dept.ID;
                    tvwDept.Nodes.Add(root);
                    LoadChildDept(deptlist, root);
                }
                tvwDept.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void LoadChildDept(List<Department> deptlist, TreeNode root)//加载子节点
        {
            foreach (Department d in deptlist.Where(d => d.ParentID == (int)root.Tag))
            {
                TreeNode node = new TreeNode(d.Name);
                node.Tag = d.ID;
                root.Nodes.Add(node);
                LoadChildDept(deptlist, node);
            }
        }

        private void tspbtnAdd_Click(object sender, EventArgs e)
        {
            if (tvwDept.SelectedNode!=null)
            {
                op = Operator.Add;
                txtDeptName.Text = "";
                txtDeptName.ReadOnly = false;
                lblParentName.Visible = true;
                lblParentName.Text = "父部门名称：" + tvwDept.SelectedNode.Text;
            }
            else
            {
                MessageBox.Show("请先选择父部门");
            }           
        }

        private void tspbtnDelete_Click(object sender, EventArgs e)
        {
            if (tvwDept.SelectedNode != null)
            {
                int id = (int)tvwDept.SelectedNode.Tag;
                string name = tvwDept.SelectedNode.Text;
                DialogResult choice = MessageBox.Show("确认删除选中部门【" + name + "】吗", "删除部门", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == DialogResult.Yes)
                {
                    if (tvwDept.SelectedNode.Nodes.Count>0)
                    {
                        MessageBox.Show("该部门有子部门，请先删除其子部门");
                    }
                    else
                    {
                        try
                        {
                            if (dbll.DeleteDept(id))
                            {
                                MessageBox.Show("删除成功");
                                tvwDept.Nodes.Clear();
                                LoadAllDept();
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
                MessageBox.Show("请选择有效的节点");
            }
        }

        private void tspbtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (tvwDept.SelectedNode != null)
            {
                op = Operator.Edit;
                txtDeptName.ReadOnly = false;
                //txtDeptName.Text = tvwDept.SelectedNode.Text;
            }
            else
            {
                MessageBox.Show("请选择有效的节点");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidataInput())
            {
                dept.Name = txtDeptName.Text.Trim();
                if (op==Operator.Add)
                {
                    dept.ParentID = (int)tvwDept.SelectedNode.Tag;
                    if (dbll.AddDept(dept))
                    {
                        MessageBox.Show("添加成功");
                        op = Operator.Other;
                        lblParentName.Visible = false;
                    }
                }
                else if (op==Operator.Edit)
                {
                    dept.ID = (int)tvwDept.SelectedNode.Tag;
                    if (dbll.EditDept(dept))
                    {
                        MessageBox.Show("修改成功");
                        op = Operator.Other;
                    }
                }
            }
            txtDeptName.ReadOnly = true;
            LoadAllDept();
        }

        private bool ValidataInput()//有效性验证
        {
            if (txtDeptName.Text.Trim() == "")
            {
                MessageBox.Show("请输入部门名称");
                txtDeptName.Focus();
                return false;
            }
            return true;
        }

        private void tvwDept_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvwDept.SelectedNode!=null)
            {
                txtDeptName.Text = tvwDept.SelectedNode.Text;
            }
        }
    }
}
