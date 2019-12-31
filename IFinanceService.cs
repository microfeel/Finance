/*  
 /
 / MicroFeel Fanance Interface
 /
 */

using MicroFeel.Finance.Interfaces;

namespace MicroFeel.Finance
{
    /// <summary>
    /// 财务API
    /// </summary>
    public partial interface IFinanceService : IBasicService, IBarcodeService, IHrService, IPlatformService, IPurchaseService, ISaleService, IStockService, IUserService, IVoucherService
    {

    }
}
