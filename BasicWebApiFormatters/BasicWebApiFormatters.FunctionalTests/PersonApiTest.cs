using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicWebApiFormatters.FunctionalTests
{
    [TestClass]
    public class PersonApiTest
    {
        [TestMethod]
        public void ShouldPostAPersonSuccessfully()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

            var response =
                client.PostAsync(ConfigurationManager.AppSettings["ApiServiceUrl"] + "api/person/12456",
                    new PersonProxy{Name = "sekhar", BirthDate = DateTime.Now},
                    new XmlMediaTypeFormatter()).Result;

            Assert.IsTrue(response.IsSuccessStatusCode);

            var result = response.Content.ReadAsStringAsync().Result;

            Assert.IsNotNull(result);
        }
    }

    [DataContract(Name = "Person", Namespace = "")]
    public class PersonProxy
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DateTime BirthDate { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
