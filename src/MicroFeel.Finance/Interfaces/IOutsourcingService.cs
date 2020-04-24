using MicroFeel.Finance.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Sugar.Utils;

namespace MicroFeel.Finance.Interfaces
{
    /// <summary>
    /// 委外服务
    /// </summary>
    public interface IOutsourcingService : IDisposable
    {
        SingleObjectResult<Outsourcing> GetOutsourcing(string orderno, string productnumbers);
        SingleObjectResult<Outsourcing> GetOutsourcing(string orderno);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="wherecodition"></param>
        /// <remarks>弃用expression该用action的原因是action更容易重新拆解和组合</remarks>
        /// <returns></returns>
        DataResult<Outsourcing> GetOutsourcings(int pageindex, int pagesize, Action<Outsourcing> wherecodition);

        MessageResult UpdateOutsourcing(Outsourcing outsourcing);

    }
}
