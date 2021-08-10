using MicroFeel.Finance.Models;
using Sugar.Utils;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MicroFeel.Finance.Interfaces
{
    /// <summary>
    /// 委外服务
    /// </summary>
    public interface IOutsourcingService : IDisposable
    {
        /// <summary>
        /// 获取委外订单
        /// </summary>
        /// <param name="billno">订单编号</param>
        /// <returns></returns>
        OmmainDto GetOmmain(string billno);
    }
}
