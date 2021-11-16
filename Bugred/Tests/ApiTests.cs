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
        [Test]
        public void Registration()
        {
            Helper helper = new Helper();
            
            RequestHelper requestHelper = new RequestHelper("tasks/rest/doregister");

            API body = new API()
            {
                Email = "arkadii@mail.ru",
                Name = "kololo",
                Password = "1"
            };

            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);
            Assert.AreEqual("OK", response.StatusCode.ToString());
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(body.Email, json["email"].ToString());
            Assert.AreEqual(body.Name, json["name"].ToString());
        }

        [Test]
        public void CreateUser()
        {
            Helper helper = new Helper();

            API body = new API()
            {
                  Email = "joe@example.com",
                 Password = "mySecretPass123"
            };
            RequestHelper requestHelper = new RequestHelper("/doregister");
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual("OK", response.StatusCode.ToString());
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(body.Email, json["email"].ToString());
            Assert.AreEqual(body.Password, json["password"].ToString());
        }
    }
}