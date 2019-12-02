using Angular_Azure.Dtos;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace Angular_Azure.Services
{
    public class SampleForecastService : IForecastService
    {
        private IAuthService _authService;
        public SampleForecastService(IAuthService authService)
        {
            _authService = authService;
        }

        private static string[] Summaries = new[]
         {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> GetForecasts()
        {
            //TODO: move params to config
            var auth = _authService.Auth(
                new AuthRequest
                {
                    ClientId = "iHW058LoogAk0s5k3SD9i7l4pRTULyUI",
                    ClientSecret = "sJdBQ4tG-3NGDhyAeU3cFmTuunJ7yKoCFZCuYGdvYxEu29oljZ82MDSUOLIPmtfq",
                    Audience = "api://forecasts",
                    GrantType = "client_credentials"

                });

            //TODO: Move to configuration
            var restClient = new RestClient("https://microservices-webapi.azurewebsites.net/api/forecasts");
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Authorization", $"Bearer {auth.AccessToken}");
            var response = restClient.Execute(restRequest);
            return JsonConvert.DeserializeObject<WeatherForecast[]>(response.Content);

        }
    }
}
