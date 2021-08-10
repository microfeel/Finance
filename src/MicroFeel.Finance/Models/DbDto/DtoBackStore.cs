using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models.DbDto
{
    /// <summary>
    /// 退料传输对象
    /// </summary>
    public class DtoBackStore
    {
        /// <summary>
        /// 微信OPENID
        /// </summary>
        public string OpenId { get; set; }
        /// <summary>
        /// 品牌ID
        /// </summary>
        public int CompanyId { get; set; }
        /// <summary>
        /// 源单号
        /// </summary>
        public string SourceOrderNo { get; set; }
        /// <summary>
        /// 明细项
        /// </summary>
        public IEnumerable<StockDetail> Details { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// 制单人
        /// </summary>
        public string Maker { get; set; }
    }
    /// <summary>
    /// 库存明细项
    /// </summary>
    public class StockDetail
    {
        /// <summary>
        /// 存货编码
        /// </summary>
        public string InvCode { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Qty { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        public string BatchCode { get; set; }
        /// <summary>
        ///源Id
        /// </summary>
        public int? SourceEntryId { get; set; }
        /// <summary>
        /// 仓库编码
        /// </summary>
        public string StoreCode { get; set; }
        /// <summary>
        /// 源出库单明细Id
        /// </summary>
        public long AutoId { get; set; }
    }

}
