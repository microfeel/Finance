using MicroFeel.Finance.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroFeel.Finance.Interfaces
{
    /// <summary>
    /// 平台级别服务
    /// </summary>
    public interface IPlatformService : IDisposable
    {
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <returns></returns>
        Task<string> TokenAsync();

        /// <summary>
        /// 获取交易号
        /// </summary>
        /// <returns>交易号</returns>
        Task<string> TradeidAsync();


        /// <summary>
        /// 获取应用订单状态
        /// </summary>
        /// <returns>订单状态</returns>
        Task<OrderStatus> Get_OrderStatusAsync();

        /// <summary>
        /// 获取数据源配置
        /// </summary>
        /// <returns>数据源配置</returns>
        Task<Datasource> Get_DatasourceAsync();

        /// <summary>
        /// 批量获取数据源配置
        /// </summary>
        /// <returns>数据源配置</returns>
        Task<IEnumerable<Datasource>> Batch_get_DatasourceAsync();

    }
}