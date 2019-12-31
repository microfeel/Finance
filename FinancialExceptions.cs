using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance
{
    public class FinancialException : Exception
    { 
        public FinancialException(string message) : base(message)
        {
        }
    }

    public class FinancialConfigException : FinancialException
    {
        public FinancialConfigException(string message) : base(message)
        {
        }
    }
}
