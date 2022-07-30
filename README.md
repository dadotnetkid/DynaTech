# How to use DynDataGrid
## Installation

Install the dependencies and devDependencies and start the server.

```sh
Install-Package DynaBlazor 
```

## Development
_Layout.cshtml
```sh
<head>
    <link rel="stylesheet" href="_content/DynaBlazor/bootstrap-5.2/bootstrap.css" />
    <link href="_content/DynaBlazor/DynaBlazor.css" rel="stylesheet" />
<head>
....
<script src="_framework/blazor.server.js"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
<script  src="_content/DynaBlazor/DynaBlazor.js" ></script>
```
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
DI Container
```sh
 builder.Services.AddScoped<HomeAdaptor>();
```
