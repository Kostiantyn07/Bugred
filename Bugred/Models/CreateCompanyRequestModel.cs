using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public CreateCompanyRequestModel( string email_owner, string company_name, string company_type, string company_users)
        {
            
            this.CompanyName = company_name;
            this.CompanyType = company_type;
            this.EmailOwner = email_owner;
            this.CompanyUsers = company_users;
        }
    }
}
