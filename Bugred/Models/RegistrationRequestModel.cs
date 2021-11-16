using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("companyType")]
        public string CompanyType { get; set; }

        [JsonProperty("emailOwner")]
        public string EmailOwner { get; set; }

        [JsonProperty("companyUsers")]
        public string CompanyUsers { get; set; }

        //public RegistrationRequestModel(string email, string name, string password, string emailOwner, string companyName, string companyType, string companyUsers)
        //{
        //    this.Email = email;
        //    this.Name = name;
        //    this.Password = password;
        //    this.CompanyName = companyName;
        //    this.CompanyType = companyType;
        //    this.EmailOwner = emailOwner;
        //    this.CompanyUsers = companyUsers;
        //}
    }
}
