using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models.DbDto
{
    public class DtoStockOrder
    {
        public string OrderNo { get; set; }

        public string SourceOrderNo { get; set; }
        public class DtoStoreStockDetail
        {
            public string ProductNumbers { get; set; }
            public decimal? Numbers { get; set; }
            public string ProductBatch { get; set; }
            public int? SourceEntryId { get; set; }
            public string StoreId { get; set; }
        }
        public IEnumerable<DtoStoreStockDetail> StoreStockDetail { get; set; }
        public string Brand { get; set; }
        public string Note { get; set; }
    }
}
