using System.Collections.Generic;

namespace MicroFeel.Finance
{
    /// <summary>
    /// 通用科目
    /// </summary>
    public class Account
    {
        /// <summary>
        /// 科目Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 科目代码
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 科目名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 科目级别
        /// </summary>
        public short Flevel { get; set; }
        /// <summary>
        /// 是否末级科目
        /// </summary>
        public bool IsDetail { get; set; }
        /// <summary>
        /// 父科目Id
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 根科目Id
        /// </summary>
        public int RootId { get; set; }
        /// <summary>
        /// 是现金科目
        /// </summary>
        public bool? IsCash { get; set; }
        /// <summary>
        /// 是银行科目
        /// </summary>
        public bool? IsBank { get; set; }
        /// <summary>
        /// 科目消息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 核算项Id集合
        /// </summary>
        public IEnumerable<int> ItemClasses { get; set; }
    }
}
