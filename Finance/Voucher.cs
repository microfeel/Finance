using System;

namespace MicroFeel.Finance
{
    /// <summary>
    /// 凭证回执
    /// </summary>
    public class Voucher
    {
        /// <summary>
        /// 凭证内码
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 凭证字id
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// 会计年度
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// 会计期间
        /// </summary>
        public int Period { get; set; }
        /// <summary>
        /// 凭证时间
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 凭证编号
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 业务编码
        /// </summary>
        public string Reference { get; set; }
        /// <summary>
        /// 是否是新建数据
        /// </summary>
        public bool IsNew { get; set; }
        /// <summary>
        /// 重载字符串表达
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Date.ToString("yyyy.MM.dd")} {Id}:{GroupId}_{Year}.{Period}.{Number}_{Reference}";
        }
    }
}
