using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// 核算项
        /// </summary>
        public int FItemId { get; set; }
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
        /// 电话号码
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
    }

}
