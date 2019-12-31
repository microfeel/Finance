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
    public partial interface IFinanceService : IBasicService, IBarcodeService, IHrService, IPlatFormService, IPurchaseService, ISaleService, IStockService, IUserService, IVoucherService
    {

    }
}
