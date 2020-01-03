using MicroFeel.Finance.Models;
using System;
using System.Collections.Generic;

namespace MicroFeel.Finance.Interfaces
{
    public interface IBasicService : IDisposable
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
        /// 获取仓库
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        List<Store> GetStores(string brand);
        /// <summary>
        /// 获取仓位
        /// </summary>
        /// <param name="storecode"></param>
        /// <returns></returns>
        List<Store> GetPlaces(string storecode);
        /// <summary>
        /// 获取工作车间
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        List<Store> GetWorkShops(string brand);
    }
}
