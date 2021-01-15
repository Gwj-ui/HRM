using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambow.HRM.Model
{
   public class User
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 登录名称
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }
        /// <summary>
        /// 所属角色编号
        /// </summary>
        public int RoleID { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        public bool IsActive { get; set; }
    }
}
