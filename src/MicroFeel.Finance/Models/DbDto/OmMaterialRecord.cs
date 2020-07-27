/*  
 /
 / MicroFeel Fanance Interface
 /
 */

namespace MicroFeel.Finance
{
    /// <summary>
    /// 委外订单领料记录
    /// </summary>
    public class OmMaterialRecord
    {
        /// <summary>
        /// 订单明细ID
        /// </summary>
        public int MoDetailId { get; set; }
        /// <summary>
        /// 应领数量
        /// </summary>
        public decimal? IQuantity { get; set; }
        /// <summary>
        /// 单位数量
        /// </summary>
        public decimal? IUnitQuantity { get; set; }
        /// <summary>
        /// 已领数量
        /// </summary>
        public decimal? ISendQty { get; set; }
        /// <summary>
        /// 材料编码
        /// </summary>
        public string CInvCode { get; set; }
    }
}