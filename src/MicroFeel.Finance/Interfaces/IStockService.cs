using MicroFeel.Finance.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroFeel.Finance.Interfaces
{
    /// <summary>
    /// 出入库服务接口
    /// </summary>
    public interface IStockService
    {
        /// <summary>
        /// 获取到货单
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页记录数</param>
        /// <param name="billState">页状态</param>
        /// <returns></returns>
        PagedResult<DispatchBill> GetDispatchBills(string brand, int pageIndex, int pageSize, DispatchBillState billState);

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
        /// <summary>
        /// 获取发货单详情
        /// </summary>
        /// <param name="billNo"></param>
        /// <returns></returns>
        IList<DispatchBillDetail> GetDispatchBillDetail(string billNo);
        /// <summary>
        /// 获取委外订单原材料领用数据
        /// </summary>
        /// <param name="ommainBillNo">委外订单号</param>
        /// <returns>原材料信用清单</returns>
        IEnumerable<OmMaterialRecord> GetOmMaterialRecords(string ommainBillNo);
        /// <summary>
        /// 通过编号获取发货单
        /// </summary>
        /// <param name="billNo">发货单编号</param>
        /// <returns></returns>
        DispatchBill GetDispatchBillByCode(string billNo);
    }
}
