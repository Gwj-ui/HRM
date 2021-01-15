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
    public partial class FrmSexReport : Form
    {
        EmployeeBLL empbll = new EmployeeBLL();

        public FrmSexReport()
        {
            InitializeComponent();
        }

        private void FrmSexReport_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = empbll.GetSexData();
                chart1.Series[0].Points.DataBindXY(dt.Rows, "Sex", dt.Rows, "empcount");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
