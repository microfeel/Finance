using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models.DbDto
{
    /// <summary>
    /// 领料单
    /// </summary>
    public class DtoMaterialOrder
    {
        public int Id { get; set; }
        public string Maker { get; set; }
        public string OrderNo { get; set; }
        public string Remark { get; set; }
        public string DepartmentName { get; set; }
        public DateTime CreateDate { get; set; }
        public string ProductName { get; set; }
        public string ProductModel { get; set; }
        public string ProductNumbers { get; set; }
        public decimal Numbers { get; set; }
        public string Brand { get; set; }
        public List<DtoMaterialOrderDetail> MaterialOrderDetails { get; set; }
        public class DtoMaterialOrderDetail
        {
            public int Id { get; set; }
            public string ProductName { get; set; }
            public string ProductNumbers { get; set; }
            public decimal Numbers { get; set; }
            public string UnitName { get; set; }
            public string ProductModel { get; set; }
            public string ProductBatch { get; set; }
            public string StoreCode { get; set; }
            public string StoreName { get; set; }
        }
    }
}
