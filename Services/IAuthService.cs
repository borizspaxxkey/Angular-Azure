using Newtonsoft.Json;

namespace Angular_Azure.Services
{
    public interface IAuthService
    {
        AuthResponse Auth(AuthRequest req);
    }

    public class AuthResponse
    {
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }


        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }


        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }


        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }
    }



    public class AuthRequest
    {
        [JsonProperty(PropertyName = "client_id")]
        public string ClientId { get; set; }


        [JsonProperty(PropertyName = "client_secret")]
        public string ClientSecret { get; set; }


        [JsonProperty(PropertyName = "audience")]
        public string Audience { get; set; }


        [JsonProperty(PropertyName = "grant_type")]
        public string GrantType { get; set; }

    }
}
