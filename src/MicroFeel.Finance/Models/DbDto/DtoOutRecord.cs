using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models.DbDto
{
    /// <summary>
    /// 材料出库记录
    /// </summary>
    public class DtoOutRecord
    {
        /// <summary>
        /// 出库单号
        /// </summary>
        public string OrderNo { get; set; }
        /// <summary>
        /// 仓库编码
        /// </summary>
        public string WhCode { get; set; }
        /// <summary>
        /// 存货编码
        /// </summary>
        public string InvCode { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        public string Batch { get; set; }
        /// <summary>
        /// 明细ID
        /// </summary>
        public long AutoId { get; set; }
        /// <summary>
        /// 可退数量
        /// </summary>
        public decimal RQuantity { get; set; }
        /// <summary>
        /// 实发数据
        /// </summary>
        public decimal SendQuantity { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        public string Name { get; set; }
    }
}
