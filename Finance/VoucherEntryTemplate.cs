using System.Collections.Generic;

namespace MicroFeel.Finance
{
    /// <summary>
    /// 凭证模板分录
    /// </summary>
    public class VoucherEntryTemplate
    {
        /// <summary>
        /// 分录序号
        /// </summary>
        public int EntryId { get; set; }
        /// <summary>
        /// 摘要
        /// </summary>
        public string Explanation { get; set; }
        /// <summary>
        /// 科目Id
        /// </summary>
        public int AccountId { get; set; }
        /// <summary>
        /// 详细Id
        /// </summary>
        public int DetailId { get; set; }
        /// <summary>
        /// 币别内码
        /// </summary>
        public int CurrencyId { get; set; }
        /// <summary>
        /// 汇率
        /// </summary>
        public double ExchangeRate { get; set; }
        /// <summary>
        /// 余额方向
        /// </summary>
        public short Dc { get; set; }
        /// <summary>
        /// 原币金额
        /// </summary>
        public decimal AmountFor { get; set; }
        /// <summary>
        /// 本币金额
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public double Quantity { get; set; }
        /// <summary>
        /// 计量单位内码
        /// </summary>
        public int MeasureUnitId { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public double UnitPrice { get; set; }
        /// <summary>
        /// 辅助核算类型
        /// </summary>
        public IEnumerable<int> ItemClasses { get; set; }
    }
}
