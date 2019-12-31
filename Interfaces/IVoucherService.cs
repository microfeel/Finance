using MicroFeel.Finance.Models;
using System;
using System.Collections.Generic;

namespace MicroFeel.Finance.Interfaces
{
    public interface IVoucherService : IDisposable
    {
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
