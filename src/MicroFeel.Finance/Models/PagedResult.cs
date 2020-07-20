using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicroFeel.Finance
{
    public class PagedResult<T> where T : class
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public List<T> Results { get; set; } = new List<T>();

        public PagedResult() { }

        public PagedResult(int totalCount, IEnumerable<T> source, int pageIndex, int pageSize):this()
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = totalCount;
            if (source != null)
            {
                Results = source.ToList();
            }
        }
    }
}
