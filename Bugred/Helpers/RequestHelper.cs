using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugred
{
    class RequestHelper
    {
        private RestClient _client;

        private string mainUrl = "http://users.bugred.ru/tasks/rest";

        public RequestHelper(string path)
        {
            _client = new RestClient(mainUrl + path)
            { Timeout = 3000000 };
        }

        public IRestResponse SendPostRequest(object body) 
        {
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(body));

            // Метод который передает запрос (объект, который он дальше прокидывает)
            IRestResponse response = _client.Execute(request);
            return response;
        }
    }
}
