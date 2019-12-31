using System.Collections.Generic;

namespace MicroFeel.Finance
{
    /// <summary>
    /// 添加凭证参数
    /// </summary>
    public class VoucherParmEntry
    {
        /// <summary>
        /// 类型
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 凭证分录参数
        /// </summary>
        public IList<VoucherParm> VoucherParms { get; set; }
    }
}
