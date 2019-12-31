using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance
{
    /// <summary>
    /// 通用凭证模板
    /// </summary>
    public class VoucherTemplate
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 模板名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 模板类型ID
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// 凭证字
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// 参考信息
        /// </summary>
        public string Reference { get; set; }
        /// <summary>
        /// 附件张数
        /// </summary>
        public int? Attachments { get; set; }
        /// <summary>
        /// 模板明细
        /// </summary>
        public IList<VoucherEntryTemplate> VoucherEntryTemplates { get; set; }

    }
}
