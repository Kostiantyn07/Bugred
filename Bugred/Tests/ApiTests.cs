using Bugred.Models;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;


namespace Bugred
{
    public class Tests
    {
        [Test]
        public void Registration()
        {
            Helper helper = new Helper();

            RequestHelper requestHelper = new RequestHelper("tasks/rest/doregister");

            RegistrationRequestModel body = new RegistrationRequestModel()
            {
                Email = "arkadii@mail.ru",
                Name = "kololo",
                Password = "1"
            };

            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);
            Assert.AreEqual("OK", response.StatusCode.ToString());
            Assert.AreEqual(body.Email, json["email"].ToString());
            Assert.AreEqual(body.Name, json["name"].ToString());
        }

        [Test]
        public void CreateUser()
        {
            CreateUserRequestModel body = new CreateUserRequestModel()
            {
                Email = "joe@example.com",
                //Password = "mySecretPass123"
            };
            RequestHelper requestHelper = new RequestHelper("/doregister");
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual("OK", response.StatusCode.ToString());
            Assert.AreEqual(body.Email, json["email"].ToString());
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
    }
}