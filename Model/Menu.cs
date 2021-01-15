using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambow.HRM.Model
{
   public class Menu
    {
        /// <summary>
        /// 菜单编号
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 菜单显示文本
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 菜单是否可分配
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// 父菜单编号
        /// </summary>
        public int ParentID { get; set; }
        /// <summary>
        /// 菜单显示顺序
        /// </summary>
        public int DisplayIndex { get; set; }
    }
}
