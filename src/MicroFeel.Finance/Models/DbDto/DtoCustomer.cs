using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models
{
    public class DtoCustomer
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string Region { get { return Province + City; } }

        public string Province { get; set; }
        public string City { get; set; }
    }
}
