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


        RequestHelper requetHelper = new RequestHelper("http://users.bugred.ru/");
        IRestResponse response = requetHelper.SendPostRequest(model);


        public RequestHelper(string requestUrl)
        {
            _client = new RestClient(requestUrl);
        }

        public IRestResponse SendGetRequest(Dictionary<string, string> parametrs)
        {
            RestRequest = new RestRequest(Method.GET);
            requst.AddHeader("content-type", "application/json");

            foreach (var param in parametrs)
                request.AddParametr(param.Key, param.Value);

            IRestResponse response = _client.Execute(request);
            return response;
        }

        public IRestResponse SendPostRequest(object body)
        {
            RestRequest request = new RestRequect(Method.POST);
            request.AddHeader("content-type", "application/json");

            request.RequestFormat = DataFormat = DataFormat.Json;
            request.AddJsonBody(JsonConvert.SerializeObject(body));

            IRestResponse response = _client.Execute(request);
            return response;
        }
    }
}
