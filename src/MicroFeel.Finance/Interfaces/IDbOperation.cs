using MicroFeel.Finance.Models;
using MicroFeel.Finance.Models.DbDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Interfaces
{
    public interface IDbOperation
    {

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
        List<DtoAllotOrder> GetAllotOrders(string brand, string orderno, DateTime? starttime, DateTime? endtime, bool isChecked, int pageindex, int pagesize, out int total);

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
        List<DtoAllotOutRecord> GetAllotOutRecords(string brand, string orderno, DateTime? starttime, DateTime? endtime, bool isChecked, int pageindex, int pagesize, out int total);
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
        /// <param name="total"></param>
        /// <returns></returns>
        List<DtoAllotRecord> GetAllotRecords(string brand, string orderno, DateTime? starttime, DateTime? endtime, bool isChecked, int pageindex, int pagesize, out int total);

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
        List<DtoAllotInRecord> GetAllotInRecords(string brand, string orderno, DateTime? starttime, DateTime? endtime, bool isChecked, int pageindex, int pagesize, out int total);

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
        /// 获取销售发货单
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="orderno"></param>
        /// <param name="isclose"></param>
        /// <returns></returns>
        List<DtoSellOrder> GetSellOrders(string brand, string orderno, bool isclose = false);

        /// <summary>
        /// 采购到货单
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="orderno"></param>
        /// <returns></returns>
        List<DtoPurchaseOrder> GetPurchaseOrders(string brand, string orderno);
        /// <summary>
        /// 获取到货单 包含委外和采购
        /// </summary>
        /// <param name="brand">品牌</param>
        /// <param name="key">单号</param>
        /// <param name="supplier">供应商</param>
        /// <param name="starttime">开始时间</param>
        /// <param name="state"></param>
        /// <param name="endtime">结束时间</param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        List<DtoPurchaseOrder> GetPurchaseOrders(string brand, string key, string supplier, string state, DateTime? starttime, DateTime? endtime, int pageindex, int pagesize, out int total);

        /// <summary>
        /// 获取初审通过单据
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="suppliercode"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        List<DtoPurchaseOrder> GetCheckedPOs(string brand, string suppliercode, int pageindex, int pagesize, out int total);

        /// <summary>
        /// 获取客户已经确认单据
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="suppliercode"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        List<DtoPurchaseOrder> GetAffirmPOs(string brand, string suppliercode, int pageindex, int pagesize, out int total);

        /// <summary>
        /// 获取客户已经发货单据
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="suppliercode"></param>  
        /// <param name="total"></param>
        /// <returns></returns>
        List<DtoPurchaseOrder> GetDeliverPOs(string brand, string suppliercode, int pageindex, int pagesize, out int total);


        /// <summary>
        /// 获取客户已经发货单据
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="suppliercode"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        List<DtoPurchaseOrder> GetOverPOs(string brand, string suppliercode, int pageindex, int pagesize, out int total);

        /// <summary>
        /// 获取采购订单单据明细
        /// </summary>
        /// <param name="orderno"></param>
        /// <returns></returns>
        List<DtoPurchaseOrder.DtoPurchaseOrderDetail> GetPODetails(string orderno);

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
        List<DtoMaterialOrder> GetMaterials(string departmentcode, string key, DateTime? starttime, DateTime? endtime, int pageindex, int pagesize, out int total);
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
        List<DtoMaterialOrder.DtoMaterialOrderDetail> GetMaterialDetails(string orderno);

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
        /// <param name="stroecode"></param>
        /// <param name="key"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        (int, List<DtoInventory>) GetInventory(string brand, string classcode, string stroecode, string key, int pageindex, int pagesize);
        /// <summary>
        /// 获取存货
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="classcode"></param>
        /// <param name="storecode"></param>
        /// <param name="key"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        List<DtoInventory> GetInventory(string brand, string classcode, string storecode, string key, int pageindex, int pagesize, out int total);

        #region Add


        /// <summary>
        /// 添加委外加工到货单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        bool AddPuarrivalVouch(DtoStockOrder order);

        /// <summary>
        /// 添加采购到货单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        bool AddPurchaseArrivalVouch(DtoStockOrder order);

        /// <summary>
        /// 添加采购入库订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        bool AddPurchaseOrder(DtoStockOrder order);

        /// <summary>
        /// 添加销售出库订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        bool AddSellOrder(DtoStockOrder order);

        /// <summary>
        /// 添加领料出库订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        bool AddMaterialOrder(DtoStockOrder order);

        /// <summary>
        /// 添加领料申请单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        bool AddMetarialApply(DtoStockOrder order);

        /// <summary>
        /// 添加退料申请单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        bool AddReturnMetarialApply(DtoStockOrder order);
        /// <summary>
        /// 从到货单下推入库单
        /// </summary>
        /// <param name="puarrivalOrderNo">到货单号</param>
        /// <returns></returns>
        bool FromPuArrivalVouchToStoreRecord(string puarrivalOrderNo);

        #endregion

        #region Update
        /// <summary>
        /// 更新单据状态
        /// </summary>
        /// <param name="orderno"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        bool UpdatePurchaseOrderState(string orderno, string state);
        #endregion
    }
}
