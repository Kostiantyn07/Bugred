﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public CreateUserRequestModel(string email, string name, string tasks, string companies)
        {
            this.Email = companies;
            this.Name = tasks;
            this.Tasks = name;
            this.Companies = email;
        }
    }
}
