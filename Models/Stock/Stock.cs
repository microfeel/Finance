using System.Collections.Generic;

namespace MicroFeel.Finance.Models
{
    /// <summary>
    /// 出入库实体
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// 明细
        /// </summary>
        public IList<StockDetial> StockDetials { get; set; }
    }
}