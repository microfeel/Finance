using MicroFeel.Finance.Models;
using MicroFeel.Finance.Models.DbDto;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Interfaces
{
    public interface IDbOperation
    {
        /// <summary>
        /// 事务
        /// </summary>
        //IDbContextTransaction BeginTransaction();

        #region 基础资料
        /// <summary>
        /// 获取部门信息
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> GetDepartments();

        /// <summary>
        /// 获取部门信息
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> GetDepartments(string departmentcode);

        /// <summary>
        /// 获取仓库信息
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> GetWarehouses();

        /// <summary>
        /// 获取客户数据
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> GetCustomers();

        DtoCustomer GetCustomers(string code);

        /// <summary>
        /// 获取用户地址，item1是省市区信息，item2是详细地址
        /// </summary>
        /// <param name="orderno"></param>
        /// <returns></returns>
        (string, string) GetCustomersByDispatch(string orderno);
        /// <summary>
        /// 依据发货单号获取客户信息
        /// </summary>
        /// <param name="orderno"></param>
        /// <returns></returns>
        DtoCustomer GetCustomersByOrderNo(string orderno);
        /// <summary>
        /// 获取商品大类
        /// </summary>
        /// <param name="cwhcode"></param>
        /// <returns></returns>
        List<DtoProductClass> GetInventoryClass(string cwhcode);

        /// <summary>
        /// 获取商品大类
        /// </summary>
        /// <returns></returns>
        List<DtoProductClass> GetInventoryClass();

        /// <summary>
        /// 获取职员
        /// </summary>
        /// <param name="phonecode"></param>
        /// <returns></returns>
        DtoPerson GetPersonByPhone(string phonecode);

        /// <summary>
        /// 获取职员
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        DtoPerson GetPerson(string code);
        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        DtoPerson GetPersonByName(string name);

        /// <summary>
        /// 获取供应商ByPhoneCode
        /// </summary>
        /// <param name="phonecode"></param>
        /// <returns></returns>
        DtoSupplier GetSupplierByPhone(string phonecode);

        /// <summary>
        /// 获取供应商
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        DtoSupplier GetSupplier(string code);
        #endregion


        #region  调拨
        /// <summary>
        /// 获取调拨单
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="orderno"></param>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <param name="isChecked"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        PagedResult<DtoAllotOrder> GetAllotOrders(string brand, string orderno, DateTime? starttime, DateTime? endtime, bool isChecked, int pageindex, int pagesize);

        /// <summary>
        /// 调拨出库单
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="orderno"></param>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <param name="isChecked"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        PagedResult<DtoAllotOutRecord> GetAllotOutRecords(string brand, string orderno, DateTime? starttime, DateTime? endtime, bool isChecked, int pageindex, int pagesize);
        /// <summary>
        /// 获取调拨单明细（出库）
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="orderno"></param>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <param name="isChecked"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        PagedResult<DtoAllotRecord> GetAllotRecords(string brand, string orderno, DateTime? starttime, DateTime? endtime, bool isChecked, int pageindex, int pagesize);

        /// <summary>
        /// 调拨入库单
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="orderno"></param>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <param name="isChecked"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        PagedResult<DtoAllotInRecord> GetAllotInRecords(string brand, string orderno, DateTime? starttime, DateTime? endtime, bool isChecked, int pageindex, int pagesize);

        /// <summary>
        /// 审核调拨入库单
        /// </summary>
        /// <param name="orderno"></param>
        /// <returns></returns>
        bool CheckAllotInRecord(string orderno);

        /// <summary>
        /// 审核调拨出库单
        /// </summary>
        /// <param name="orderno"></param>
        /// <returns></returns>
        bool CheckAllotOutRecord(string orderno);

        /// <summary>
        /// 获取进入仓库
        /// </summary>
        /// <param name="outorderno"></param>
        /// <returns></returns>
        string GetAllotTargetWHCode(string outorderno);

        /// <summary>
        /// 检验出库记录
        /// </summary>
        /// <param name="orderno"></param>
        /// <param name="autoid"></param>
        /// <returns></returns>
        bool CheckAllotOutRecord(string orderno, string autoid);
        #endregion

        /// <summary>
        /// 获取委外生产产品明细单
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="key"></param>
        /// <param name="supplier"></param>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        PagedResult<DtoOutsourcingOrder> GetOutsourcingOrders(string brand, string key, string supplier, DateTime? starttime, DateTime? endtime, int pageindex, int pagesize);

        /// <summary>
        /// 获取销售发货单
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="orderno"></param>
        /// <param name="isclose"></param>
        /// <returns></returns>
        List<DtoSellOrder> GetSellOrders(string brand, string orderno, bool isclose = false);

        /// <summary>
        /// 获取采购到货单
        /// </summary>
        /// <param name="ordertype">单据类型</param>
        /// <param name="brand">品牌</param>
        /// <param name="orderno">单号</param>
        /// <param name="state">状态</param>
        /// <returns></returns>
        DtoPurchaseOrder GetPurchaseOrder(string ordertype, string brand, string orderno, string state);
        /// <summary>
        /// 获取到货单 包含委外和采购
        /// </summary>
        /// <param name="ordertype">单据类型 （普通采购/委外加工）</param>
        /// <param name="brand">品牌</param>
        /// <param name="key">单号</param>
        /// <param name="supplier">供应商</param>
        /// <param name="starttime">开始时间</param>
        /// <param name="state">状态</param>
        /// <param name="endtime">结束时间</param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        PagedResult<DtoPurchaseOrder> GetPurchaseOrders(string ordertype, string brand, string key, string supplier, string state, DateTime? starttime, DateTime? endtime, int pageindex, int pagesize);

        /// <summary>
        /// 获取初审通过单据
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="suppliercode"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        PagedResult<DtoPurchaseOrder> GetCheckedPOs(string brand, string suppliercode, int pageindex, int pagesize);

        /// <summary>
        /// 获取客户已经确认单据
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="suppliercode"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        PagedResult<DtoPurchaseOrder> GetAffirmPOs(string brand, string suppliercode, int pageindex, int pagesize);

        /// <summary>
        /// 获取客户已经发货单据
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="suppliercode"></param>  
        /// <param name="total"></param>
        /// <returns></returns>
        PagedResult<DtoPurchaseOrder> GetDeliverPOs(string brand, string suppliercode, int pageindex, int pagesize);


        /// <summary>
        /// 获取客户已经发货单据
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="suppliercode"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        PagedResult<DtoPurchaseOrder> GetOverPOs(string brand, string suppliercode, int pageindex, int pagesize);

        /// <summary>
        /// 获取采购订单单据明细
        /// </summary>
        /// <param name="orderno"></param>
        /// <returns></returns>
        List<DtoPurchaseOrderDetail> GetPODetails(string orderno);

        /// <summary>
        /// 获取领料申请单
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="departmentcode"></param>
        /// <returns></returns>
        List<DtoMaterialOrder> GetMaterialOrders(string brand, string departmentcode);


        /// <summary>
        /// 获取领料单
        /// </summary>
        /// <param name="departmentcode"></param>
        /// <param name="key"></param>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        PagedResult<DtoMaterialOrder> GetMaterials(string departmentcode, string key, DateTime? starttime, DateTime? endtime, int pageindex, int pagesize);
        /// <summary>
        /// 获取领料单
        /// </summary>
        /// <param name="orderno"></param>
        /// <returns></returns>
        DtoMaterialOrder GetMaterials(string orderno);
        /// <summary>
        /// 获取领料明细
        /// </summary>
        /// <param name="orderno"></param>
        /// <returns></returns>
        List<DtoMaterialOrderDetail> GetMaterialDetails(string orderno);

        /// <summary>
        /// 获取存货
        /// </summary>
        /// <param name="productcode"></param>
        DtoInventory GetInventory(string productcode);

        /// <summary>
        /// 获取存货
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="classcode"></param>
        /// <param name="storecode"></param>
        /// <param name="key"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        PagedResult<DtoInventory> GetInventory(string brand, string classcode, string storecode, string key, int pageindex, int pagesize);

        #region Add


        /// <summary>
        /// 添加委外加工到货单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        void AddPuarrivalVouch(DtoStockOrder order);

        /// <summary>
        /// 添加采购到货单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        void AddPurchaseArrivalVouch(DtoStockOrder order);

        /// <summary>
        /// 添加采购入库订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        void AddPurchaseOrder(DtoStockOrder order);

        /// <summary>
        /// 添加销售出库订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        void AddSellOrder(DtoStockOrder order);

        /// <summary>
        /// 添加领料出库订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        void AddMaterialOrder(DtoStockOrder order);

        /// <summary>
        /// 添加领料申请单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        void AddMetarialApply(DtoStockOrder order);

        /// <summary>
        /// 添加退料申请单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        void AddReturnMetarialApply(DtoStockOrder order);
        /// <summary>
        /// 从到货单下推入库单
        /// </summary>
        /// <param name="puarrivalOrderNo">到货单号</param>
        /// <returns></returns>
        void FromPuArrivalVouchToStoreRecord(string puarrivalOrderNo);

        /// <summary>
        /// 从到货单下推入库单
        /// </summary>
        /// <param name="puarrivalOrderNo">到货单号</param>
        /// <param name="batchs">批号</param>
        /// <returns></returns>
        void FromPuArrivalVouchToStoreRecord(string puarrivalOrderNo, Dictionary<string, string> batchs);

        /// <summary>
        /// 从到货单下推入库单
        /// </summary>
        /// <param name="puarrivalOrderNo">到货单号</param>
        /// <param name="sendOrderNo">供应商/委外工厂 发货单号</param> 
        /// <returns></returns>
        void FromPuArrivalVouchToStoreRecord(string puarrivalOrderNo, string sendOrderNo);

        #endregion

        #region Update
        /// <summary>
        /// 更新单据状态
        /// </summary>
        /// <param name="orderno"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        void UpdatePurchaseOrderState(string orderno, string state);

        /// <summary>
        /// 更新 cDefine14
        /// </summary>
        /// <param name="billNo"></param>
        /// <param name="statusName"></param>
        void UpdateStatusBills(string billNo, string statusName);
        #endregion

        #region Close
        /// <summary>
        /// 关闭到货单
        /// </summary>
        /// <param name="orderno">单号</param>
        /// <param name="closer">关闭人</param>
        /// <param name="action">事务内需要做的事情</param>
        /// <param name="tran">事务</param>
        /// <returns></returns>
        void ClosePurarrivalOrderTransaction(string orderno, string closer, Func<bool, bool> action);
        #endregion
    }
}
