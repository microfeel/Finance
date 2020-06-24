namespace MicroFeel.Finance.Models
{
    /// <summary>
    /// 发货单明细
    /// </summary>
    public class DispatchBillDetail
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 发货单号
        /// </summary>
        public string BillNo { get; set; }
        /// <summary>
        /// 仓库编码
        /// </summary>
        public string WhCode { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WhName { get; set; }
        /// <summary>
        /// 存货编码
        /// </summary>
        public string InvCode { get; set; }
        /// <summary>
        /// 存货名称
        /// </summary>
        public string InvName { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        public string Batch { get; set; }
        /// <summary>
        /// 未发货数量
        /// </summary>
        public decimal Qty { get; set; }
        /// <summary>
        /// 总发货数量
        /// </summary>
        public decimal TotalQty { get; set; }
    }
}