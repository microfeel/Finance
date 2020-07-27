﻿/*  
 /
 / MicroFeel Fanance Interface
 /
 */

using MicroFeel.Finance.Interfaces;
using MicroFeel.Finance.Models;
using System.Collections.Generic;

namespace MicroFeel.Finance
{
    /// <summary>
    /// 财务API
    /// </summary>
    public partial interface IFinanceService : IBasicService, IPlatformService, IStockService, IVoucherService, IOutsourcingService, IDbOperation
    {
    }
}
