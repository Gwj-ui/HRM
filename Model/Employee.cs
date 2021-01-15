using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambow.HRM.Model
{
   public class Employee
    {
        /// <summary>
        /// 员工编号
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 部门编号
        /// </summary>
        public int DepartmentID { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        public string Nation { get; set; }
        /// <summary>
        /// 政治面貌
        /// </summary>
        public string Polity { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        public string Degree { get; set; }
        /// <summary>
        /// 月薪
        /// </summary>
        public decimal Salary { get; set; }
        /// <summary>
        /// 个人履历
        /// </summary>
        public string Resume { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 是否在职
        /// </summary>
        public bool Status { get; set; }
    }
}
