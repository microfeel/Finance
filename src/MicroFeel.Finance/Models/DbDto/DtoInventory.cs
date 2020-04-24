using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models.DbDto
{
    public class DtoInventory
    {
        public string ProductName { get; set; }
        public string ProductNumbers { get; set; }
        public string ProductModel { get; set; }
        public string InventoryClassName { get; set; }
        public string InventoryClassCode { get; set; }
        public string UnitName { get; set; }
        public double Rate { get; set; }
        public double? MinStoreNumbers { get; set; }
        public double? MaxStoreNumbers { get; set; }

        public List<DtoInventoryStock> InventoryStocks { get; set; }

        public class DtoInventoryStock
        {
            public string StoreCode { get; set; }
            public string ProductBatchNo { get; set; }
            public decimal Numbers { get; set; }
            public string StoreName { get; set; }
        }
    }
}
