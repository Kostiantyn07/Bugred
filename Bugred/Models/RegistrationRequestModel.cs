using Newtonsoft.Json;

namespace Bugred
{
    public class RegistrationRequestModel
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

       
    }
}
