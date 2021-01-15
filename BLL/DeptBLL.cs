using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambow.HRM.DAL;
using Ambow.HRM.Model;

namespace Ambow.HRM.BLL
{
   public class DeptBLL
    {
        DeptDAL ddal = new DeptDAL();
        public List<Department> GetAllDepartment()
        {
            return ddal.GetAllDepartment();
        }

        public bool AddDept(Department dept)
        {
            return ddal.AddDept(dept) > 0;
        }

        public bool EditDept(Department dept)
        {
            return ddal.EditDept(dept) > 0;
        }

        public bool DeleteDept(int ID)
        {
            return ddal.DeleteDept(ID) > 0;
        }
    }
}
