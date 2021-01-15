using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambow.HRM.DAL;
using Ambow.HRM.Model;

namespace Ambow.HRM.BLL
{
   public class MenuBLL
    {
        MenuDAL mdal = new MenuDAL();
        public List<Menu> GetAllMenus()
        {
            return mdal.GetAllMenus();
        }

        public List<Menu> GetMenusByRoleID(int RoleID)
        {
            return mdal.GetMenusByRoleID(RoleID);
        }
    }
}
