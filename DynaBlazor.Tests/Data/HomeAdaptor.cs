using DynaBlazor.Adaptors;
using DynaBlazor.Common;

namespace DynaBlazor.Tests.Data
{
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
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
                },
                new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary="weather is hot4",
                    TemperatureC=355
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
}
