using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models.DbDto
{
    public partial class DtoAllotInRecord
    {
        public string OrderNo { get; set; }
        public DateTime CreateTime { get; set; }
        public string Remark { get; set; }
        public string Brand { get; set; }
        public string StoreName { get; set; } 

        public List<DtoAllotInRecordDetail> AllotInRecordDetails { get; set; }
    }

    public class DtoAllotInRecordDetail
    {
        public string ProductName { get; set; }
        public string ProductNumbers { get; set; }
        public decimal Numbers { get; set; }
        public string ProductModel { get; set; }
        public string UnitName { get; set; }
    }
}
