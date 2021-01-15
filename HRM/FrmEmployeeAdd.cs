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
    public partial class FrmEmployeeAdd : Form
    {
        Employee emp;
        EmployeeBLL empbll = new EmployeeBLL();
        DeptBLL dbll = new DeptBLL();
        Operator op = Operator.Other;

        public FrmEmployeeAdd()
        {
            InitializeComponent();
            this.op = Operator.Add;
            emp = new Employee();
            this.Text = "添加员工";
        }

        public FrmEmployeeAdd(Employee emp)
        {
            InitializeComponent();
            this.emp = emp;
            this.op = Operator.Edit;
            this.Text = "员工信息维护";
        }

        private void FrmEmployeeAdd_Load(object sender, EventArgs e)
        {
            DisplayDept();
            if (op == Operator.Edit)
            {
                if (emp != null)
                {
                    txtName.Text = emp.Name;
                    rdoMale.Checked = (emp.Sex == "男") ? true : false;
                    rdoFemale.Checked = (emp.Sex == "女") ? true : false;
                    ckbStatus.Checked = emp.Status;
                    cboDept.SelectedValue = emp.DepartmentID;
                    cboPosition.Text = emp.Position;
                    txtPhone.Text = emp.Phone;
                    txtEmail.Text = emp.Email;
                    cboNation.Text = emp.Nation;
                    cboPolity.Text = emp.Polity;
                    cboDegree.Text = emp.Degree;
                    txtSalary.Text = emp.Salary.ToString();
                    txtResume.Text = emp.Resume;
                    txtMemo.Text = emp.Memo;
                }
            }
        }

        private void DisplayDept()//加载下拉列表部门名称
        {
            try
            {
                cboDept.DataSource = dbll.GetAllDepartment();
                cboDept.DisplayMember = "Name";
                cboDept.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                emp.DepartmentID = (int)cboDept.SelectedValue;
                emp.Name = txtName.Text.Trim();
                emp.Sex = rdoMale.Checked ? "男" : "女";
                emp.Position = cboPosition.Text;
                emp.Phone = txtPhone.Text.Trim();
                emp.Email = txtEmail.Text.Trim();
                emp.Nation = cboNation.Text;
                emp.Polity = cboPolity.Text;
                emp.Degree = cboDegree.Text;
                emp.Salary = Convert.ToDecimal(txtSalary.Text.Trim());
                emp.Resume = txtResume.Text;
                emp.Memo = txtMemo.Text;
                emp.Status = ckbStatus.Checked;
                try
                {
                    if (op == Operator.Add)
                    {
                        if (empbll.AddEmployee(emp))
                        {
                            this.DialogResult = DialogResult.OK;
                            MessageBox.Show("添加成功！");
                            op = Operator.Other;
                        }
                    }
                    else if (op == Operator.Edit)
                    {
                        if (empbll.EditEmployee(emp))
                        {
                            this.DialogResult = DialogResult.OK;
                            MessageBox.Show("修改成功");
                            op = Operator.Other;
                        }
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
            if (cboDept.SelectedIndex == -1)
            {
                MessageBox.Show("请选择部门");
                cboDept.Focus();
                return false;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("请填写姓名");
                txtName.Focus();
                return false;
            }
            if (cboPosition.SelectedIndex == -1)
            {
                MessageBox.Show("请选择职位");
                cboPosition.Focus();
                return false;
            }
            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("请填写电话");
                txtPhone.Focus();
                return false;
            }
            if (txtPhone.Text.Length != 11)
            {
                MessageBox.Show("电话号码为11位");
                txtPhone.Focus();
                return false;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("请填写Email");
                txtEmail.Focus();
                return false;
            }
            //[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@(?:[\w](?:[\w-]*[\w])?\.)+[\w](?:[\w-]*[\w])?
            //Regex reg = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            //if (txtEmail.Text.Trim() != @"[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@(?:[\w](?:[\w-]*[\w])?\.)+[\w](?:[\w-]*[\w])?")
            //{
            //    MessageBox.Show("Email格式不正确");
            //    txtEmail.Focus();
            //    return false;
            //}
            if (cboNation.SelectedIndex == -1)
            {
                MessageBox.Show("请选择民族");
                cboNation.Focus();
                return false;
            }
            if (cboPolity.SelectedIndex == -1)
            {
                MessageBox.Show("请选择政治面貌");
                cboPolity.Focus();
                return false;
            }
            if (cboDegree.SelectedIndex == -1)
            {
                MessageBox.Show("请选择学历");
                cboDegree.Focus();
                return false;
            }
            if (txtSalary.Text.Trim() == "")
            {
                MessageBox.Show("请填写月薪");
                txtSalary.Focus();
                return false;
            }
            //if (txtSalary.Text.Trim() != @"^\d{4,}+?[1-9][0-9]*$")
            //{
            //    MessageBox.Show("月薪格式不正确");
            //    txtSalary.Focus();
            //    return false;
            //}
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
