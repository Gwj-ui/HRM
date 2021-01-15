using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambow.HRM.DAL;
using Ambow.HRM.Model;
using System.Data;

namespace Ambow.HRM.BLL
{
   public class EmployeeBLL
    {
        EmployeeDAL empdal = new EmployeeDAL();

        public DataTable GetEmployeeByName(string Name)
        {
            return empdal.GetEmployeeByName(Name);
        }

        public bool AddEmployee(Employee emp)
        {
            return empdal.AddEmployee(emp) > 0;
        }

        public bool EditEmployee(Employee emp)
        {
            return empdal.EditEmployee(emp) > 0;
        }

        public bool DeleteEmployee(int ID)
        {
            return empdal.DeleteEmployee(ID) > 0;
        }

        public DataTable GetSexData()
        {
            return empdal.GetSexData();
        }

        public DataTable GetDegreeData()
        {
            return empdal.GetDegreeData();
        }
    }
}
