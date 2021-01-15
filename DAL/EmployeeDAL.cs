using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambow.HRM.Model;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace Ambow.HRM.DAL
{
    public class EmployeeDAL
    {
        #region 根据姓名查询
        /// <summary>
        /// 根据姓名查询
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public DataTable GetEmployeeByName(string Name)
        {
            string sql = "select * from v_Employee where EName like @Name";
            SqlParameter[] para = new SqlParameter[] {
            new SqlParameter("@Name","%"+Name+"%")
            };
            return DBHelper.ExecuteTable(sql, CommandType.Text, para);
        }
        #endregion

        #region 添加员工
        /// <summary>
        /// 添加员工
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public int AddEmployee(Employee emp)
        {
            string sql = "insert into Employee(DepartmentID,Name,Sex,Position,Phone,Email,Nation,Polity,Degree,Salary,Resume,Memo,Status)values(@DepartmentID,@Name,@Sex,@Position,@Phone,@Email,@Nation,@Polity,@Degree,@Salary,@Resume,@Memo,@Status)";
            SqlParameter[] para = new SqlParameter[]
            {
            new  SqlParameter("@DepartmentID",emp.DepartmentID),
            new  SqlParameter("@Name",emp.Name),
            new SqlParameter("@Sex",emp.Sex),
            new  SqlParameter("@Position",emp.Position),
            new  SqlParameter("@Phone",emp.Phone),
            new SqlParameter("@Email",emp.Email),
            new  SqlParameter("@Nation",emp.Nation),
            new  SqlParameter("@Polity",emp.Polity),
            new SqlParameter("@Degree",emp.Degree),
            new  SqlParameter("@Salary",emp.Salary),
            new  SqlParameter("@Resume",emp.Resume),
            new SqlParameter("@Memo",emp.Memo),
            new SqlParameter("@Status",emp.Status)
            };
            return DBHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }
        #endregion

        #region 修改员工信息
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public int EditEmployee(Employee emp)
        {
            string sql = "update Employee set DepartmentID=@DepartmentID,Name=@Name,Sex=@Sex,Position=@Position,Phone=@Phone, Email=@Email,Nation=@Nation,Polity=@Polity,Degree=@Degree,Salary=@Salary,Resume=@Resume,Memo=@Memo,Status=@Status where ID=@ID";
            SqlParameter[] para = new SqlParameter[]
            {
            new SqlParameter("@DepartmentID",emp.DepartmentID),
            new SqlParameter("@Name",emp.Name),
            new SqlParameter("@Sex",emp.Sex),
            new SqlParameter("@Position",emp.Position),
            new SqlParameter("@Phone",emp.Phone),
            new SqlParameter("@Email",emp.Email),
            new SqlParameter("@Nation",emp.Nation),
            new SqlParameter("@Polity",emp.Polity),
            new SqlParameter("@Degree",emp.Degree),
            new SqlParameter("@Salary",emp.Salary),
            new SqlParameter("@Resume",emp.Resume),
            new SqlParameter("@Memo",emp.Memo),
            new SqlParameter("@Status",emp.Status),
            new SqlParameter("@ID",emp.ID)
            };
            return DBHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }
        #endregion

        #region 根据编号删除员工信息
        /// <summary>
        /// 根据编号删除员工信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DeleteEmployee(int ID)
        {
            string sql = "delete from Employee where ID=@ID";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ID",ID)
            };
            return DBHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }
        #endregion

        #region 按照性别统计
        /// <summary>
        /// 按照性别统计
        /// </summary>
        /// <returns></returns>
        public DataTable GetSexData()
        {
            string sql = "select Sex,count(*) as empcount from Employee where Status=1 group by Sex";
            return DBHelper.ExecuteTable(sql, CommandType.Text, null);
        }
        #endregion

        #region 按照学历统计
        /// <summary>
        /// 按照学历统计
        /// </summary>
        /// <returns></returns>
        public DataTable GetDegreeData()
        {
            string sql = "select Degree,count(*) as empcount from Employee where Status=1 group by Degree";
            return DBHelper.ExecuteTable(sql, CommandType.Text, null);
        }
        #endregion
    }
}
