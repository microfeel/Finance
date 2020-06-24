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
        /// 待处理
        /// </summary>
        Processing = 1,
        /// <summary>
        /// 已审核
        /// </summary>
        Checked = 2,
    }
}