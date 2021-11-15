using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;

namespace Bugred
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RequestTestCreate()
        {
            RestClient client = new RestClient("http://users.bugred.ru/tasks/rest/createuser") // Перенести в хелпер   // 
            {
                Timeout = 300000
            };
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
           // request.AddHeader("Authorization", "Bearer NTgxMTc3ZTgtNjUwNi00MTBhLWI1Y2MtOGY1OWNiMGI5NDRl");

            Dictionary<string, string> body = GenerateUserData();
            request.AddJsonBody(body);

            IRestResponse response = client.Execute(request);  // Метод который передает запрос (объект, который он дальше прокидывает)
                                                               // Ответ мы записываем в response //
            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual("OK", response.StatusCode.ToString());
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(body["email"], json["account"]["email"]?.ToString());
        }
        
        public Dictionary<string, string> GenerateUserData()
        {
            string now = DateTime.Now.ToString("ddMMyyyyhhmmss");
            string email = now + "@test.com";
            string userId = now;
            string userName = "Name" + now;
            return new Dictionary<string, string>()
            {
                {"email", email },
                {"id", userId},
                {"password", "mySecretPass123"},
                {"username", userName}
            };
        }
    }
}