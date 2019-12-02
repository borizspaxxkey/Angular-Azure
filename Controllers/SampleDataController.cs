using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular_Azure.Dtos;
using Angular_Azure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Angular_Azure.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private IForecastService _service;
        public SampleDataController(IForecastService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            return _service.GetForecasts();
        }
       
    }
    
}
