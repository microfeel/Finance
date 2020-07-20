namespace MicroFeel.Finance.Models
{
    /// <summary>
    /// 发货单状态
    /// </summary>
    public enum DispatchBillState
    {
        /// <summary>
        /// 全部
        /// </summary>
        All = 0,
        /// <summary>
        /// 待配货
        /// </summary>
        Processing = 1,
        /// <summary>
        /// 待发货
        /// </summary>
        Sending=2,
        /// <summary>
        /// 已完成
        /// </summary>
        Completed = 3,
    }
}