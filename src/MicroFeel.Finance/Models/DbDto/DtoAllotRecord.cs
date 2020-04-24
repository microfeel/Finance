using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models.DbDto
{
    public class DtoAllotRecord
    { 
        public string OrderNo { get; set; }
        public DateTime CreateTime { get; set; }
        public string Remark { get; set; }
        public string Brand { get; set; }
        public string StoreName { get; set; }
        public string ProductName { get; set; }
        public string ProductNumbers { get; set; }
        public decimal Numbers { get; set; }
        public string ProductModel { get; set; }
        public string UnitName { get; set; }
        public string ProductBathcNo { get; set; }
        public long AutoId { get; set; }
    }
}
