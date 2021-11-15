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
            _client = new RestClient(mainUrl + path);
        }

        public IRestResponse SendGetRequest(object body) // Буду передавать Гет.
        {
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddJsonBody(body);

            IRestResponse response = _client.Execute(request); // Метод который передает запрос (объект, который он дальше прокидывает)
            return response;
        }
    }
}
