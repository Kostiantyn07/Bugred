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
            
            API body = new API(helper.name); //name? email? password
            RequestHelper requestHelper = new RequestHelper("/doregister");
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual("OK", response.StatusCode.ToString());
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(body["email"], json["account"]["email"]?.ToString());
        }
    }
}