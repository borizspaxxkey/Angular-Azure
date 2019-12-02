using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Azure.Services
{
    public class AuthService : IAuthService
    {
        public AuthResponse Auth(AuthRequest req)
        {
            //TODO: Move these values to configuration
            var client = new RestClient("https://iamebuka-angular-azure.auth0.com/oauth/token");
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("content-type", "application/json");
            restRequest.AddParameter("application/json",
                                                    JsonConvert.SerializeObject(req), 
                                                    ParameterType.RequestBody);

            var response = client.Execute(restRequest);
            return JsonConvert.DeserializeObject<AuthResponse>(response.Content);
        }
    }
}
