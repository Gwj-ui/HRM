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
    public partial class FrmEmployee : Form
    {
        EmployeeBLL empbll = new EmployeeBLL();
        
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadAllEmployee();
        }

        private void tspbtnAdd_Click(object sender, EventArgs e)
        {
            FrmEmployeeAdd fea = new HRM.FrmEmployeeAdd();
            if (fea.ShowDialog() == DialogResult.OK)
            {
                LoadAllEmployee();
            }            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = empbll.GetEmployeeByName(txtEName.Text.Trim());
                dgvEmployee.AutoGenerateColumns = false;
                dgvEmployee.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAllEmployee()//加载所有员工信息
        {
            try
            {
                dgvEmployee.AutoGenerateColumns = false;
                dgvEmployee.DataSource = empbll.GetEmployeeByName(txtEName.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tspbtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                int id = (int)dgvEmployee.CurrentRow.Cells[0].Value;
                string name = dgvEmployee.CurrentRow.Cells[1].Value.ToString();

                DialogResult choice = MessageBox.Show("确定要删除员工【" + name + "】吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        if (empbll.DeleteEmployee(id))
                        {
                            MessageBox.Show("删除成功！");
                            LoadAllEmployee();
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
                MessageBox.Show("请先选中需要删除的行");
            }
        }

        private void tspbtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                DataGridViewRow dgvr = dgvEmployee.CurrentRow;
                Employee emp = new Employee();
                emp.ID = (int)dgvr.Cells[0].Value;
                emp.Name = dgvr.Cells[1].Value.ToString();
                emp.Sex = dgvr.Cells[2].Value.ToString();                
                emp.Position = dgvr.Cells[4].Value.ToString();
                emp.Salary = Convert.ToDecimal(dgvr.Cells[5].Value);
                emp.Phone = dgvr.Cells[6].Value.ToString();
                emp.Email = dgvr.Cells[7].Value.ToString();
                emp.Degree = dgvr.Cells[8].Value.ToString();
                emp.Status = Convert.ToBoolean(dgvr.Cells[9].Value);
                emp.DepartmentID = (int)dgvr.Cells[10].Value;
                emp.Resume = dgvr.Cells[11].Value.ToString();
                emp.Memo = dgvr.Cells[12].Value.ToString();
                emp.Polity = dgvr.Cells[13].Value.ToString();
                emp.Nation = dgvr.Cells[14].Value.ToString();
                FrmEmployeeAdd fea = new FrmEmployeeAdd(emp);
                if (fea.ShowDialog() == DialogResult.OK)
                {
                    LoadAllEmployee();
                }
            }
        }
    }
}
