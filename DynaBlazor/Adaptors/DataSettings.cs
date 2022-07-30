namespace DynaBlazor.Adaptors
{
    public class DataSettings
    {
        public IEnumerable<DataColumnSettings> ColumnsDirection{ get; set; }=Enumerable.Empty<DataColumnSettings>();
        public IEnumerable<DataFilter> DataFilter { get; set; } = Enumerable.Empty<DataFilter>();
    }

    public class DataFilter
    {
        public string? FilterBy { get; set; }
        public string FilterValue { get; set; }
    }

    public class DataColumnSettings
    {
        public string ColumnName { get; set; }
        public string OrderDirection { get; set; }
    }
}
