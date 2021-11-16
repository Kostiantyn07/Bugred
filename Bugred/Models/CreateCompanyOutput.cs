using Newtonsoft.Json;


namespace Bugred.Models
{
    class CreateCompanyOutput
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string StatusType { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("id_company")]
        public int IdCompany { get; set; }
    }
}
