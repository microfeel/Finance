using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroFeel.Finance
{
    /// <summary>
    /// 
    /// </summary>
    public class Financial
    {
        /// <summary>
        /// 财务服务类
        /// </summary>
        public IFinanceService Service;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public Financial(FinancialOptions options)
        {
            Service = FinancialFactory.Create(options.FinancialType);
        }

        /// <summary>
        /// 异步操作
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        public Task<TResult> Asnyc<TResult>(Func<IFinanceService, TResult> action)
        {
            return Task<TResult>.Run(() =>
             {
                 if (action == null)
                     throw new ArgumentNullException();
                 TResult result = action.Invoke(Service);
                 return result;
             });
        }

        /// <summary>
        /// 异步操作
        /// </summary> 
        /// <param name="action"></param>
        /// <returns></returns>
        public Task Asnyc(Action<IFinanceService> action)
        {
            return Task.Run(() =>
            {
                if (action == null)
                    throw new ArgumentNullException();
                action.Invoke(Service);
            });
        }
    }

    public static class FinancialExtension
    {

        public static IServiceCollection AddFinanceService(this IServiceCollection services, FinancialOptions options)
        {
            if (services.Any(t => t.ServiceType == typeof(Financial))) return services;
            services.AddSingleton(new Financial(options));
            return services;
        }

        public static IServiceCollection AddFinanceService(this IServiceCollection services, Action<FinancialOptions> action)
        {
            FinancialOptions options = new FinancialOptions();
            action?.Invoke(options);
            return AddFinanceService(services, options);
        }

        public static IServiceCollection AddFinanceService(this IServiceCollection services, string financeType)
        {
            FinancialType financialType;
            if (!Enum.TryParse<FinancialType>(financeType, out financialType))
                throw new ArgumentException($"参数financeType（{financeType}）内容不正确，暂不支持的财务类型");
            return AddFinanceService(services, new FinancialOptions() { FinancialType = financialType });
        }
    }
}
