using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace DynaBlazor.DataGrid
{
    public class DataGridColumnProperties<TValue> where TValue : class
    {
        public string ColumnName { get; set; }
        public string? Title { get; set; }
        public string OrderDirection { get; set; }
        public bool EnableSort{ get; set; }
        public string Width { get; set; }
        public RenderFragment<TValue>? Template { get; set; }
        public bool EnableFilter { get; set; }
    }
    
}
