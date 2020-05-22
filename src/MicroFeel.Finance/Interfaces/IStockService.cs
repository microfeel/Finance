using MicroFeel.Finance.Models;
using System;
using System.Threading.Tasks;

namespace MicroFeel.Finance.Interfaces
{
    /// <summary>
    /// 出入库服务接口
    /// </summary>
    public interface IStockService : IDisposable
    {
        /// <summary>
        /// 成品入库
        /// </summary>
        /// <param name="productin"></param>
        /// <returns></returns>
        bool ProductIn(Productin productin);

        /// <summary>
        /// 其他入库
        /// </summary>
        /// <param name="otherin"></param>
        /// <returns></returns>
        bool OtherIn(Otherin otherin);

        /// <summary>
        /// 其他出库
        /// </summary>
        /// <param name="otherout"></param>
        /// <returns></returns>
        bool OtherOut(Otherout otherout);

        /// <summary>
        /// 采购入库
        /// </summary>
        /// <param name="purchasein"></param>
        /// <param name="purchaseorderno">采购订单单号</param>
        /// <returns></returns>
        Task<bool> PurchaseInAsync(Purchasein purchasein, string purchaseorderno);

        /// <summary>
        /// 材料出库
        /// </summary>
        /// <param name="materialout"></param>
        /// <returns></returns>
        bool Materialout(Materialout materialout);

        /// <summary>
        /// 调拨单
        /// </summary>
        /// <param name="transvouch"></param>
        /// <returns></returns>
        bool Transvouch(Transvouch transvouch);

        /// <summary>
        /// 销售出库
        /// </summary>
        /// <param name="saleout"></param>
        /// <returns></returns>
        bool Saleout(Saleout saleout);
    }
}
