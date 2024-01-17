[[Nuget]: https://www.nuget.org/packages/DynaBlazor](https://www.nuget.org/packages/DynaBlazor)

[[Wiki]: https://github.com/dadotnetkid/DynaTech/wiki](https://github.com/dadotnetkid/DynaTech/wiki)


```sh
Install-Package DynaBlazor 
```


# How to use DynDataGrid
## Installation

Install the dependencies and devDependencies and start the server.

```sh
Install-Package DynaBlazor 
```

## Development

DynaGrid

```sh
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
```
HomeAdaptor.cs
```sh
  public class HomeAdaptor : DataAdaptor
    {
        public override Task<DataObject> Get(DataSettings settings)
        {

            var data = new List<WeatherForecast>()
            {
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot1",
                    TemperatureC=46
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot2",
                    TemperatureC=204
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot3",
                    TemperatureC=269
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                }
            }.AsQueryable();
            var result = data.ToDynaAdaptor(settings);


            return Task.FromResult(result);
        }
    }
```

# How to use DynModal
## Installation

Install the dependencies and devDependencies and start the server.

```sh
Install-Package DynaBlazor 
```

## Development

DynaModal

```sh
<DynaBlazor.Component.DynModal @ref="filterModal" OnModalClose="OnFilterModalClose">
    <Header>
        <h5>This is modal</h5>
    </Header>
    <Body>
        <DynaBlazor.Layout.DynGridRow>
            <DynaBlazor.Layout.DynGridColumn>
                <h5>Hello World</h5>
            </DynaBlazor.Layout.DynGridColumn>
        </DynaBlazor.Layout.DynGridRow>
  
    </Body>
    <Footer>
        <button class="btn btn-primary" >Apply</button>
    </Footer>
</DynaBlazor.Component.DynModal>
```
