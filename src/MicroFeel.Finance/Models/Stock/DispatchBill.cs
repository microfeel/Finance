using System;

namespace MicroFeel.Finance.Models
{
    /// <summary>
    /// 发货单
    /// </summary>
    public class DispatchBill
    {
        /// <summary>
        /// 单号
        /// </summary>
        public string BillNo { get; set; }
        /// <summary>
        /// 单据日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 制单人
        /// </summary>
        public string Maker { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string Customer { get; set; }
        /// <summary>
        /// 关联的出库单号
        /// </summary>
        public string OutNos { get; set; }
        /// <summary>
        /// 销售订单号
        /// </summary>
        public string SoBillNo { get; set; }
        /// <summary>
        /// 发货单状态
        /// </summary>
        public DispatchBillState State { get; set; }

        /// <summary>
        /// 客户联系人
        /// </summary>
        public string CusPerson { get; set; }
        /// <summary>
        /// 发往地址
        /// </summary>
        public string ShipAddress { get; set; }
    }
}