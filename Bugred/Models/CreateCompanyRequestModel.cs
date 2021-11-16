using Newtonsoft.Json;


namespace Bugred.Models
{
    public class CreateCompanyRequestModel
    {
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("company_type")]
        public string CompanyType { get; set; }

        [JsonProperty("email_owner")]
        public string EmailOwner { get; set; }

        [JsonProperty("company_users")]
        public string CompanyUsers { get; set; }

    }
}
