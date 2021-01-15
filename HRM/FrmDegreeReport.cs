using Ambow.HRM.BLL;
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
    public partial class FrmDegreeReport : Form
    {
        EmployeeBLL empbll = new EmployeeBLL();
        public FrmDegreeReport()
        {
            InitializeComponent();
        }

        private void FrmDegreeReport_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = empbll.GetDegreeData();
                chart1.Series[0].Points.DataBindXY(dt.Rows, "Degree", dt.Rows, "empcount");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
