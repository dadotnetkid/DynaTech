using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaBlazor.Adaptors
{
    public class DataObject
    {
        public IEnumerable<object> Data { get; set; }=Enumerable.Empty<object>();
        public int TotalPages { get; set; }
        public int TotalRows { get; set; }
        public int CurrentRow { get; set; }
        internal DataPagination Pagination { get; set; } = new();
    }
}
