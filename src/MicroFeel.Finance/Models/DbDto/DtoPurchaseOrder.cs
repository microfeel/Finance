using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models.DbDto
{
    public class DtoPurchaseOrder
    {
        public int Id { get; set; }
        public string Maker { get; set; }
        public string OrderNo { get; set; }
        public string Remark { get; set; }
        public string OrderType { get; set; }
        public string Supplier { get; set; }
        public string SupplierCode { get; set; }
        /// <summary>
        /// 发货单号
        /// </summary>
        public string SendOrderNo { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? MaxArriveDate { get; set; }

        public string State { get; set; }
        /// <summary>
        /// 入库单号
        /// </summary>
        public string StockOrderCode { get; set; }
        /// <summary>
        /// 到货单明细概要(存货编码+规格型号)
        /// </summary>
        public string Content { get; set; }

        public List<DtoPurchaseOrderDetail> PurchaseOrderDetails { get; set; } = new List<DtoPurchaseOrderDetail>();
        /// <summary>
        /// 采购订单单号
        /// </summary>
        public string PurchaseOrderNo { get; set; }

    }
    public class DtoPurchaseOrderDetail
    {
        public int AutoId { get; set; }
        public string ProductName { get; set; }
        public string ProductNumbers { get; set; }
        public decimal Numbers { get; set; }
        public string UnitName { get; set; }

        public string StoreCode { get; set; }

        public string StoreName { get; set; }

        public string ProductModel { get; set; }

        public DateTime? ArriveDate { get; set; }
        public decimal? Price { get; set; }
        public decimal Rate { get; set; }
        public string ProductBatch { get; set; }
    }

}
