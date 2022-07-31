namespace DynaBlazor.Adaptors
{
    public class DataSettings
    {
        public IEnumerable<DataColumnSettings> ColumnsDirection{ get; set; }=Enumerable.Empty<DataColumnSettings>();
        public IEnumerable<DataFilter> DataFilter { get; set; } = Enumerable.Empty<DataFilter>();
        internal DataPagination Pagination = new();
    }

    public class DataFilter
    {
        public string? FilterBy { get; set; } = string.Empty;
        public string FilterValue { get; set; } = string.Empty;
    }

    public class DataPagination
    {
        public int CurrentPage { get; set; } = 1;
        public int TotalRows { get; set; }
        public int PageSize { get; set; } = 10;
        public int TotalPages { get; set; }
    }
    public class DataColumnSettings
    {
        public string ColumnName { get; set; }
        public string OrderDirection { get; set; }
    }
}
