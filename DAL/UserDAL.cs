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
    public class UserDAL
    {
        #region 查询所有用户
        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllUsers()
        {
            string sql = "select * from v_Users";
            return DBHelper.ExecuteTable(sql, CommandType.Text, null);
        }
        #endregion

        #region 添加用户
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int AddUser(User u)
        {
            string sql = "insert into Users(Account,Password,RealName,RoleID,IsActive)values(@Account,@Password,@RealName,@RoleID,@IsActive)";
            SqlParameter[] para = new SqlParameter[]
            {
            new SqlParameter("@Account",u.Account),
            new SqlParameter("@Password",u.Password),
            new SqlParameter("@RealName",u.RealName),
            new SqlParameter("@RoleID",u.RoleID),
            new SqlParameter("@IsActive",u.IsActive)
            };
            return DBHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }
        #endregion

        #region 编辑用户信息
        /// <summary>
        /// 编辑用户信息
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int EditUser(User u)
        {
            string sql = "update Users set Account=@Account,Password=@Password,RealName=@RealName,RoleID=@RoleID,IsActive=@IsActive where ID=@ID";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@Account",u.Account),
                new SqlParameter("@Password",u.Password),
                new SqlParameter("@RealName",u.RealName),
                new SqlParameter("@RoleID",u.RoleID),
                new SqlParameter("@IsActive",u.IsActive),
                new SqlParameter("@ID",u.ID)
            };
            return DBHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }
        #endregion

        #region 根据编号删除用户
        /// <summary>
        /// 根据编号删除用户
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DeleteUser(int ID)
        {
            string sql = "delete from Users where ID=@ID";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ID",ID),
            };
            return DBHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }
        #endregion

        #region 根据登录名获取用户对象
        /// <summary>
        /// 根据登录名获取用户对象
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public User GetUsesByName(string name)
        {
            User u = null;
            string sql = "select * from Users where IsActive=1 and Account=@Account";
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@Account",name)
            };
            using (SqlDataReader dr = DBHelper.ExecuteReader(sql, CommandType.Text, para))
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        u = new User();
                        u.ID = (int)dr["ID"];
                        u.Account = dr["Account"].ToString();
                        u.Password = dr["Password"].ToString();
                        u.RealName = dr["RealName"].ToString();
                        u.RoleID = (int)dr["RoleID"];
                    }
                }
            }
            return u;
        }
        #endregion

        #region 修改密码
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int ChangePwd(string Password,int ID)
        {
            string sql = "update Users set Password=@Password where ID=@ID";
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@Password",Password),
                 new SqlParameter("@ID",ID)
            };
            return DBHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }
        #endregion
    }
}
