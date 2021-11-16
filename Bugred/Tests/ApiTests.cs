using Bugred.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;
using System.Threading;

namespace Bugred
{
    public class Tests
    {
        [Test]
        public void Registration()
        {      
            RequestHelper requestHelper = new RequestHelper("tasks/rest/doregister");

            RegistrationRequestModel body = new RegistrationRequestModel()
            {
                Email = Helper.RandomStringGeneration() + "@example.com",
                Name = "Name" + Helper.RandomStringGeneration(),
                Password = "1"
            };

            IRestResponse response = requestHelper.SendPostRequest(body);

            var json = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);

            Assert.AreEqual("OK", response.StatusCode.ToString());
            Assert.AreEqual(body.Email, json["email"].ToString());
            Assert.AreEqual(body.Name, json["name"].ToString());
        }



        [Test]
        public void CreateUser()
        {
            RequestHelper requestHelper = new RequestHelper("/createuser");
            CreateUserRequestModel body = new CreateUserRequestModel()
            {
                Email = Helper.RandomStringGeneration() + "@example.com",
                Name = "Name" + Helper.RandomStringGeneration(),
                Tasks = new List<int>() { 56 },
                Companies = new List<int>() { 7, 8 }
            };

            IRestResponse response = requestHelper.SendPostRequest(body);


            var json = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);

            Assert.AreEqual("OK", response.StatusCode.ToString());
            Assert.AreEqual(body.Email, json["email"]?.ToString());

        }

        [Test]
        public void CreateUserWithTasks()
        {
            RegistrationRequestModel body = new RegistrationRequestModel()
            {
                Email = "testfop@mail.com",
                Name = "Рестовый 3",
            };
            RequestHelper requestHelper = new RequestHelper("/doregister");
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual("OK", response.StatusCode.ToString());
            Assert.AreEqual(body.Email, json["email"].ToString());
            Assert.AreEqual(body.Name, json["name"].ToString());
        }

        [Test]
        public void CreateCompany()
        {
            Helper helper = new Helper();

            CreateCompanyRequestModel body = new CreateCompanyRequestModel()
            {
                CompanyName = "Алкоголики и тунеядцы",
                CompanyType = "ООО",
                EmailOwner = "aa+1@mail.com",
                //CompanyUsers = new List<string>()
            };

            RequestHelper requestHelper = new RequestHelper("/doregister");
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual("OK", response.StatusCode.ToString());
            Assert.AreEqual(body.CompanyName, json["companyName"].ToString());
            Assert.AreEqual(body.CompanyType, json["companyType"].ToString());
            Assert.AreEqual(body.EmailOwner, json["emailOwner"].ToString());
        }

        //[TestCase("", "name", "password", "message")]
        //public void TestDoRegisterUserWithEmptyEmail(string email, string name, string password)
        //{
        //    Helper helper = new Helper();
        //    //  RegistrationRequestModel body = new RegistrationRequestModel()
        //    //RequestHelper requestHelper = new RequestHelper()
        //    //    if (email == "valid") email = Helper.UniqueStringGeneration + "@test.com";
        //    //{
        //    //    Dictionary<string, string> body = new Dictionary<string, string>

        //    //     {"email", email },
        //    //     { "name", name},
        //    //    { "password", "Password123"}

        //    //}

        //    IRestResponse response = requestHelper.SendPostRequest(body);
        //    JObject json = JObject.Parse(response.Content);
        //    Assert.AreEqual("OK", response.StatusCode.ToString());
        //    Assert.AreEqual(body.Email, json["email"].ToString());
        //    Assert.AreEqual(body.Name, json["name"].ToString());
        //}
    }
}