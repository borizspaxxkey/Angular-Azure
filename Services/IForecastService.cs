using Angular_Azure.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Azure.Services
{
    public interface IForecastService
    {
        IEnumerable<WeatherForecast> GetForecasts();
    }
}
