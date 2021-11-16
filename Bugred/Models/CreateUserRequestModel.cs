using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Bugred.Models
{
    public class CreateUserRequestModel
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tasks")]
        public List<int> Tasks { get; set; }

        [JsonProperty("companies")]
        public List<int> Companies { get; set; }
    }
}
