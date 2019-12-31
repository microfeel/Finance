using MicroFeel.Finance.Models;
using System;

namespace MicroFeel.Finance.Interfaces
{
    /// <summary>
    /// 出入库服务接口
    /// </summary>
    public interface IStockService : IDisposable
    {
        bool AddStock(Stock stock);

       
    }
}
