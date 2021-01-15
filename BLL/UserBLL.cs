using Ambow.HRM.DAL;
using Ambow.HRM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambow.HRM.BLL
{
    public enum LoginResults
    {
        Success,InvalidAccount,PwdError
    }
   public class UserBLL
    {
        UserDAL udal = new UserDAL();

        public DataTable GetAllUsers()
        {
            return udal.GetAllUsers();
        }
        public int AddUser(User u)
        {
            return udal.AddUser(u);
        }

        public bool EditUser(User u)
        {
            return udal.EditUser(u)>0;
        }

        public bool DeleteUser(int ID)
        {
            return udal.DeleteUser(ID)>0;
        }

        public bool ChangePwd(string Password, int ID)
        {
            return udal.ChangePwd(Password,ID) >0;
        }

        public LoginResults Login(string name,string pwd,out User validateUser)
        {
            User u = udal.GetUsesByName(name);
            if (u==null)
            {
                validateUser = null;
                return LoginResults.InvalidAccount;
            }
            else
            {
                if (u.Password==pwd)
                {
                    validateUser = u;
                    return LoginResults.Success;
                }
                else
                {
                    validateUser = null;
                    return LoginResults.PwdError;
                }
            }
        }
    }
}
