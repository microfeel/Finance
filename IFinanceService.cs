/*  
 /
 / MicroFeel Fanance Interface
 /
 */

using System;
using System.Collections.Generic;

namespace MicroFeel.Finance
{
    /// <summary>
    /// 财务API
    /// </summary>
    public interface IFinanceService : IDisposable
    {
        /// <summary>
        /// 添加客户核算项
        /// </summary>
        /// <param name="customer">通用客户对象</param>
        Customer AddCustomer(Customer customer);
        /// <summary>
        /// 添加客户核算项
        /// </summary>
        /// <param name="customer">通用客户对象</param>
        /// <param name="predicate">财务对象的定位表达式</param>
        /// <param name="parameters">实际参数</param>
        /// <returns></returns>
        Customer AddCustomer(Customer customer, string predicate, params object[] parameters);
        /// <summary>
        /// 添加部门核算项
        /// </summary>
        /// <param name="dep">通用部门对象</param>
        Department AddDepartment(Department dep);
        /// <summary>
        /// 添加职员核算项
        /// </summary>
        /// <param name="emp">通用职员对象</param>
        Emp AddEmployee(Emp emp);
        /// <summary>
        /// 添加职员核算项
        /// </summary>
        /// <param name="emp">通用职员对象</param>
        /// <param name="predicate">职员数据的定位表达式</param>
        /// <param name="parameters">实际参数</param>
        /// <returns></returns>
        Emp AddEmployee(Emp emp, string predicate, params object[] parameters);
        /// <summary>
        /// 添加供应商核算项
        /// </summary>
        /// <param name="supplier">通用供应商对象</param>
        Supplier AddSupplier(Supplier supplier);
        /// <summary>
        /// 添加物料核算项
        /// </summary>
        /// <param name="material">通用材料对象</param>
        Material AddMaterial(Material material);
        /// <summary>
        /// 添加通用核算项
        /// </summary>
        /// <param name="item">通用核算对象</param>
        Item AddItem(Item item);
        /// <summary>
        /// 添加凭证
        /// </summary>
        /// <param name="voucherParams">凭证参数</param>
        /// <param name="explanation">摘要</param>
        /// <param name="reference">参考信息</param>
        /// <param name="preparer">制单人</param>
        /// <param name="groupID">凭证字内码</param>
        /// <param name="date">凭证日期</param>
        /// <param name="transDate">业务日期</param>
        /// <param name="objectName">对象名称</param>
        /// <param name="parameter">参数</param>
        Voucher AddVoucher(IList<VoucherParmEntry> voucherParams, string explanation, string reference, string preparer, int groupID, DateTime date, DateTime transDate, string objectName = "", string parameter = "");
        /// <summary>
        /// 添加凭证
        /// </summary>
        /// <param name="voucherInfo">凭证信息</param>
        /// <returns></returns>
        Voucher AddVoucher(VoucherInfo voucherInfo);
        /// <summary>
        /// 获取凭证模板
        /// </summary>
        /// <param name="tempTypeNames">模板类型名称</param>
        /// <returns>模板数据</returns>
        IList<VoucherTemplate> GetVoucherTemplate(IEnumerable<string> tempTypeNames);
        /// <summary>
        /// 获取所有凭证模板
        /// </summary>
        /// <returns>模板数据</returns>
        IList<VoucherTemplate> GetVoucherTemplate();
        /// <summary>
        /// 获取系统科目
        /// </summary>
        /// <returns></returns>
        IList<Account> GetAccount();
    }
}
