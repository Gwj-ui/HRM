using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambow.HRM.Model
{
   public class Department
    {
        /// <summary>
        /// 部门编号
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 父部门编号
        /// </summary>
        public int ParentID { get; set; }
    }
}
