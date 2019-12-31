using System.Collections.Generic;

namespace MicroFeel.Finance
{
    /// <summary>
    /// 凭证参数
    /// </summary>
    public class VoucherParm
    {
        /// <summary>
        /// 核算类别，核算编号(Number)
        /// </summary>
        public Dictionary<int, string> ItemDict { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public double Quantity { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public double UnitPrice { get; set; }

        /// <summary>
        /// 单位名称
        /// </summary>
        public string MeasureUnit { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 借方科目
        /// </summary>
        public int Account { get; set; }

        /// <summary>
        /// 贷方科目
        /// </summary>
        public int Account2 { get; set; }

        /// <summary>
        /// 0贷方，1借方(此数据应该读取 T_Account表中的FDC）
        /// </summary>
        public short FDC { get; set; }
        /// <summary>
        /// 摘要
        /// </summary>
        public string Explanation { get; set; }
    }
}
