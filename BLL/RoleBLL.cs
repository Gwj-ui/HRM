using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambow.HRM.DAL;
using Ambow.HRM.Model;

namespace Ambow.HRM.BLL
{
   public class RoleBLL
    {
        RoleDAL rdal = new RoleDAL();
        public List<Role> GetAllRoles()
        {
            return rdal.GetAllRoles();
        }

        public int AddRole(string RoleName, int[] ids)
        {
            return rdal.AddRole(RoleName, ids);
        }

        public int EditRole(int RoleID, string RoleName, int[] ids)
        {
            return rdal.EditRole(RoleID, RoleName, ids);
        }

        public int DeleteRole(int RoleID)
        {
            return rdal.DeleteRole(RoleID);
        }

        public bool IsUse(int RoleID)
        {
            if(rdal.GetUsersCountByRolrID(RoleID)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
