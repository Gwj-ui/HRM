using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Ambow.HRM.Model;
using DAL;
using System.Data;

namespace Ambow.HRM.DAL
{
    public class RoleDAL
    {
        #region 获取所有角色列表
        /// <summary>
        /// 获取所有角色列表
        /// </summary>
        /// <returns></returns>
        public List<Role> GetAllRoles()
        {
            List<Role> list = new List<Role>();
            string sql = "select * from Role";
            using (SqlDataReader dr = DBHelper.ExecuteReader(sql, CommandType.Text, null))
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Role role = new Role();
                        role.ID = (int)dr["ID"];
                        role.Name = dr["Name"].ToString();
                        list.Add(role);
                    }
                }
            }
            return list;
        }
        #endregion

        #region 添加角色
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="RoleName"></param>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int AddRole(string RoleName, int[] ids)
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(DBHelper.connStr))
            {
                try
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();
                    try
                    {
                        string sql1 = "insert into Role(Name)values(@RoleName);select @@identity";
                        SqlParameter[] para1 = new SqlParameter[]
                        {
                            new SqlParameter("RoleName",RoleName)
                        };
                        int RoleID = Convert.ToInt32(DBHelper.ExecuteScalar(sql1, CommandType.Text, para1, tran));
                        foreach (int i in ids)
                        {
                            string sql2 = "insert into RoleMenu(RoleID,MenuID)values(@RoleID,@MenuID)";
                            SqlParameter[] para2 = new SqlParameter[]
                            {
                                new SqlParameter("@RoleID",RoleID),
                                new SqlParameter("@MenuID",i)
                            };
                            count += DBHelper.ExecuteNonQuery(sql2, CommandType.Text, para2, tran);
                        }
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return count;
        }

        #endregion

        #region 编辑角色
        /// <summary>
        /// 编辑角色
        /// </summary>
        /// <param name="RoleID"></param>
        /// <param name="RoleName"></param>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int EditRole(int RoleID,string RoleName,int[]ids)
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(DBHelper.connStr))
            {
                try
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();
                    try
                    {
                        string sql1 = "update Role set Name=@RoleName where ID=@RoleID";
                        SqlParameter[] para1 = new SqlParameter[]
                        {
                            new SqlParameter("@RoleName",RoleName),
                            new SqlParameter("@RoleID",RoleID)
                        };
                        count += DBHelper.ExecuteNonQuery(sql1, CommandType.Text, para1,tran);
                        string sql2 = "delete from RoleMenu where RoleID=@RoleID";
                        SqlParameter[] para2 = new SqlParameter[]
                        {
                            new SqlParameter("@RoleID",RoleID)
                        };
                        count += DBHelper.ExecuteNonQuery(sql2, CommandType.Text, para2,tran);
                        foreach (int i in ids)
                        {
                            string sql3 = "insert into RoleMenu(RoleID,MenuID)values(@RoleID,@MenuID)";
                            SqlParameter[] para3 = new SqlParameter[]
                            {
                                new SqlParameter("@RoleID",RoleID),
                                new SqlParameter("@MenuID",i)
                            };
                            count += DBHelper.ExecuteNonQuery(sql3, CommandType.Text, para3, tran);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return count;
        }
        #endregion

        #region 删除角色
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="RoleID"></param>
        /// <returns></returns>
        public int DeleteRole(int RoleID)
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(DBHelper.connStr))
            {
                try
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();
                    try
                    {
                        string sql1 = "delete from RoleMenu where RoleID=@RoleID";
                        SqlParameter[] para1 = new SqlParameter[]
                        {
                            new SqlParameter("@RoleID",RoleID)
                        };
                        count += DBHelper.ExecuteNonQuery(sql1, CommandType.Text, para1, tran);
                        string sql2 = "delete from Role where ID=@RoleID";
                        SqlParameter[] para2 = new SqlParameter[]
                        {
                             new SqlParameter("@RoleID",RoleID)
                        };
                        count += DBHelper.ExecuteNonQuery(sql2, CommandType.Text, para2, tran);
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return count;
        }
        #endregion

        #region 根据角色获取相应的用户数量
        /// <summary>
        /// 根据角色获取相应的用户数量
        /// </summary>
        /// <param name="RoleID"></param>
        /// <returns></returns>
        public int GetUsersCountByRolrID(int RoleID)
        {
            string sql = "select count(*)from Users where RoleID=@RoleID";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@RoleID",RoleID)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar(sql, CommandType.Text, para));
        }
        #endregion
    }
}
