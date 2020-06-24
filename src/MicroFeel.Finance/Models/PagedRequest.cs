using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance
{
    public class PagedRequest<T> where T : class
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
