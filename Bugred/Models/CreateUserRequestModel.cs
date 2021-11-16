using Newtonsoft.Json;

namespace Bugred.Models
{
    public class CreateUserRequestModel
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tasks")]
        public string Tasks { get; set; }

        [JsonProperty("companies")]
        public string Companies { get; set; }

    }
}
