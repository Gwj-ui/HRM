using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambow.HRM.Model;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace Ambow.HRM.DAL
{
    public class DeptDAL
    {
        #region 获取所有部门名称
        /// <summary>
        /// 获取所有部门名称
        /// </summary>
        /// <returns></returns>
        public List<Department> GetAllDepartment()
        {
            List<Department> list = new List<Department>();
            string sql = "select * from Department";
            using (SqlDataReader dr = DBHelper.ExecuteReader(sql, CommandType.Text, null))
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Department d = new Department();
                        d.ID = (int)dr["ID"];
                        d.Name = dr["Name"].ToString();
                        d.ParentID = (dr["ParentID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ParentID"]);
                        list.Add(d);
                    }
                }
            }
            return list;
        }
        #endregion

        #region 添加部门
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public int AddDept(Department dept)
        {
            string sql = "insert into Department(Name,ParentID)values(@Name,@ParentID)";
            SqlParameter[] para = new SqlParameter[]
            {
               new SqlParameter("@Name",dept.Name),
               new SqlParameter("@ParentID",dept.ParentID)
            };
            return DBHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }
        #endregion

        #region 编辑部门
        /// <summary>
        /// 编辑部门
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public int EditDept(Department dept)
        {
            string sql = "update Department set Name=@Name where ID=@ID";
            SqlParameter[] para = new SqlParameter[]
            {
               new SqlParameter("@Name",dept.Name),
               new SqlParameter("@ID",dept.ID)
            };
            return DBHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }
        #endregion

        #region 删除部门
        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DeleteDept(int ID)
        {
            string sql = "delete from Department where ID=@ID";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ID",ID)
            };
            return DBHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }
        #endregion
    }
}
