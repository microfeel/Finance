using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace MicroFeel.Finance
{
    internal class FinancialFactory
    {
        private static Dictionary<string, IFinanceService> services = new Dictionary<string, IFinanceService>();

        public static IFinanceService Create(FinancialType financialType, params object[] parameters)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                throw new FinancialException("工厂构造异常:\r\n" + ex.ToString());
            }
        }

        public static TServcie Create<TServcie>(params object[] parameters) where TServcie : class, IFinanceService
        {
            try
            {
                var typeTServcie = typeof(TServcie);
                if (services.ContainsKey(typeTServcie.FullName))
                    return services[typeTServcie.FullName] as TServcie;
                var instance = Activator.CreateInstance(typeTServcie, parameters) as TServcie;
                services.Add(typeTServcie.FullName, instance);
                return instance;
            }
            catch (Exception ex)
            {
                throw new FinancialException("工厂构造异常:\r\n" + ex.ToString());
            }
        }
    }
}
