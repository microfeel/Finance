﻿/*  
 /
 / MicroFeel Fanance Interface
 /
 */

using MicroFeel.Finance.Interfaces;
using MicroFeel.Finance.Models;
using MicroFeel.Finance.Models.DbDto;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace MicroFeel.Finance
{
    /// <summary>
    /// 财务API
    /// </summary>
    public partial interface IFinanceService : IBasicService, IPlatformService, IStockService, IVoucherService, IOutsourcingService, IDbOperation
    {
    }
}
