using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models
{
    /// <summary>
    /// 通用核算项
    /// </summary>
    public class Item
    {
        /// <summary>
        /// 核算项
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// 核算项类型ID
        /// </summary>
        public int ItemClassId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 短编码
        /// </summary>
        public string ShortNumber { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
    }
}
