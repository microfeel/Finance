using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models.DbDto
{
    public class DtoSellOrder
    {
        public int Id { get; set; }
        public string Maker { get; set; }
        public string OrderNo { get; set; }
        public string Remark { get; set; }
        public string RecevieAddress { get; set; }
        public string ReceiveTel { get; set; }
        public string Receiver { get; set; }
        public DateTime CreateDate { get; set; }
        public string ReceiveCompany { get; set; }
        public List<DtoSellOrderDetail> SellOrderDetails { get; set; }


    }

    public class DtoSellOrderDetail
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductNumbers { get; set; }
        public bool? IsBatchManage { get; set; }
        public string ProductBatchNo { get; set; }
        public decimal Numbers { get; set; }
        public string ProcutModel { get; set; }
        public string UnitName { get; set; }
    }
}
