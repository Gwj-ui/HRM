using Ambow.HRM.Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambow.HRM.DAL
{
   public class MenuDAL
    {
        #region 获取所有菜单列表
        /// <summary>
        /// 获取所有菜单列表
        /// </summary>
        /// <returns></returns>
        public List<Menu> GetAllMenus()
        {
            List<Menu> list = new List<Menu>();
            string sql = "select * from Menus where IsActive = 1 order by ParentID, DisplayIndex";
            using (SqlDataReader dr = DBHelper.ExecuteReader(sql, CommandType.Text, null))
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Menu menu = new Menu();
                        menu.ID = (int)dr["ID"];
                        menu.Name = dr["Name"].ToString();
                        menu.Text = dr["Text"].ToString();
                        menu.IsActive = (bool)dr["IsActive"];
                        menu.ParentID = (dr["ParentID"] == DBNull.Value) ? 0 : (int)dr["ParentID"];
                        menu.DisplayIndex = (int)dr["DisplayIndex"];
                        list.Add(menu);
                    }
                }
            }
            return list;
        }
        #endregion

        #region 通过角色获取菜单权限
        /// <summary>
        /// 通过角色获取菜单权限
        /// </summary>
        /// <param name="RoleID"></param>
        /// <returns></returns>
        public List<Menu>GetMenusByRoleID(int RoleID)
        {
            List<Menu> list = new List<Menu>();
            string sql = "select * from RoleMenu inner join Menus on RoleMenu.MenuID=Menus.ID where RoleMenu.RoleID=@RoleID";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@RoleID",RoleID)
            };
            using (SqlDataReader dr = DBHelper.ExecuteReader(sql, CommandType.Text, para))
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Menu m = new Menu();
                        m.ID = (int)dr["ID"];
                        m.Name = dr["Name"].ToString();
                        list.Add(m);
                    }
                }
            }
            return list;
        }
        #endregion
    }
}
