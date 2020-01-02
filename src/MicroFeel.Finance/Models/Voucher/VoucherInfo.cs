using System;
using System.Collections.Generic;

namespace MicroFeel.Finance.Models
{
    /// <summary>
    /// 凭证信息
    /// </summary>
    public class VoucherInfo
    {
        /// <summary>
        /// 凭证参数
        /// </summary>
        public IList<VoucherParmEntry> VoucherParams { get; set; }
        /// <summary>
        /// 凭证主表摘要,一般不存储数据
        /// </summary>
        public string Explanation { get; set; }
        /// <summary>
        /// 参考信息
        /// </summary>
        public string Reference { get; set; }
        /// <summary>
        /// 制单人
        /// </summary>
        public string Preparer { get; set; }
        /// <summary>
        /// 凭证字
        /// </summary>
        public int GroupID { get; set; }
        /// <summary>
        /// 凭证时间
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 业务时间
        /// </summary>
        public DateTime TransDate { get; set; }
        /// <summary>
        /// 子系统
        /// </summary>
        public string ObjectName { get; set; } = "";
        /// <summary>
        /// 参数
        /// </summary>
        public string Parameter { get; set; } = "";
    }
}
