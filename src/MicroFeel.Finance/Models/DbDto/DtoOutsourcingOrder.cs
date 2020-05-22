using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models.DbDto
{
    public class DtoOutsourcingOrder
    {
        public DateTime DateTime { get; set; }
        public int DetailId { get; set; }
        public string OrderNo { get; set; }
        public DateTime? CommitDate { get; set; }
        public string ProductName { get; set; }
        public string ProductModel { get; set; }
        public string ProductNumbers { get; set; }
        public decimal? Numbers { get; set; }
    }
}
