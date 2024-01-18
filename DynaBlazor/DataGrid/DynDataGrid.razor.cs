using DynaBlazor.Adaptors;
using DynaBlazor.Component;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;

namespace DynaBlazor.DataGrid;

public partial class DynDataGrid<TValue> where TValue : class
{
    [Inject] private IServiceScopeFactory ServiceScopeFactory { get; set; }

    //[Parameter]public bool InlineEditing { get; set; } = false;
    [Parameter] public RenderFragment Columns { get; set; }
    [Parameter] public Type? Adaptor { get; set; }
    [Parameter] public EventCallback<List<DataFilter>> OnAppliedFilters { get; set; }
    public IEnumerable<TValue>? LoadedData { get; set; }
    internal DataAdaptor? AdaptorType { get; set; }
    internal List<DataGridColumnProperties<TValue>> ColumnsProperty = new();
    internal List<DataFilter> DataFilters { get; set; } = new();
    private DataPagination dataPagination = new();
    private DataFilter dataFilter = new();
    private DynModal filterModal;

    private async Task LoadData()
    {
        if (AdaptorType != null)
        {
            var get = await AdaptorType.Get(new()
            {
                ColumnsDirection = ColumnsProperty.Where(x => !string.IsNullOrEmpty(x.OrderDirection)).Select(x => new DataColumnSettings()
                {
                    ColumnName = x.ColumnName,
                    OrderDirection = x.OrderDirection
                }),
                DataFilter = DataFilters,
                Pagination = dataPagination
            });
            dataPagination = get.Pagination;
            LoadedData = get.Data as IEnumerable<TValue>;
        }

    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (Adaptor != null)
            {
                AdaptorType = ServiceScopeFactory.CreateScope().ServiceProvider.GetRequiredService(Adaptor) as DataAdaptor;
                await LoadData();
                StateHasChanged();
            }
        }
    }
    public void SetColumns(List<(string columnName, string title, bool isTemplate)> columns)
    {
        StateHasChanged();
    }

    private async Task SortBy(DataGridColumnProperties<TValue> dataGridColumnProperties)
    {
        if (!dataGridColumnProperties.EnableSort) return;
        switch (dataGridColumnProperties.OrderDirection)
        {
            case "asc":
                dataGridColumnProperties.OrderDirection = "desc";
                break;
            case "desc":
                dataGridColumnProperties.OrderDirection = "asc";
                break;
            default:
                dataGridColumnProperties.OrderDirection = "asc";
                break;
        }
        await LoadData();
        StateHasChanged();
    }

    public async Task ReloadDataServer()
    {
        await LoadData();
        StateHasChanged();
    }


    private async Task OpenFilterModal()
    {
        await filterModal.Open();
    }

    private async Task ApplyFilter()
    {
        if (!string.IsNullOrEmpty(dataFilter.FilterBy) && !string.IsNullOrEmpty(dataFilter.FilterValue))
        {
            DataFilters.Add(dataFilter);
        }

        if (DataFilters.Any())
        {
            await OnAppliedFilters.InvokeAsync(DataFilters);
        }
        await filterModal.Close();
    }


    private async Task RemoveFilter(DataFilter _datafilter)
    {
        DataFilters.Remove(_datafilter);
        await LoadData();
    }

    private async Task OnFilterModalClose()
    {
        await LoadData();
        dataFilter = new();
    }

    private async Task PagePrevious()
    {
        if (dataPagination.CurrentPage == 1) return;
        dataPagination.CurrentPage -= 1;
        await LoadData();
    }

    private async Task PageNext()
    {
        if (dataPagination.TotalPages == dataPagination.CurrentPage) return;
        dataPagination.CurrentPage += 1;
        await LoadData();
    }

    private async Task OnPage(int i)
    {
        dataPagination.CurrentPage = i;
        await LoadData();
    }
}