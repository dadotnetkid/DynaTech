<DynaBlazor.DataGrid.DynDataGrid TValue="WeatherForecast" Adaptor="typeof(HomeAdaptor)" @ref="dynDataGrid">
            <Columns>
                <DataGridColumn ColumnName="Summary" Title="Summary" TValue="WeatherForecast" OrderBy="Common.DataGridOrderBy.Desc" Width="10%" />
                <DataGridColumn ColumnName="TemperatureF" Title="TemperatureF" TValue="WeatherForecast" EnableSort="false" Width="25%" />
                <DataGridColumn Title="Date" TValue="WeatherForecast" Width="25%">
                    <Template Context="item">
                        <td>
                            <button @onclick="@(()=>Test(item))">Open</button>
                        </td>
                    </Template>
                </DataGridColumn>
            </Columns>
</DynaBlazor.DataGrid.DynDataGrid>
