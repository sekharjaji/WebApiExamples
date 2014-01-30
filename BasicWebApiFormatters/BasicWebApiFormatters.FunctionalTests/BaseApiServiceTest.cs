using System;
using System.Configuration;
using System.Net.Http;

namespace BasicWebApiFormatters.FunctionalTests
{
    public class BaseApiServiceTest
    {
        protected ApiServiceClient Client;
        protected string ApiUrl;

        public BaseApiServiceTest()
        {
            Client = new ApiServiceClient();
            ApiUrl = ConfigurationManager.AppSettings["ApiServiceUrl"];
        }

        protected T PostAsync<T>(string url, HttpContent content)
        {
            var response = Client.PostAsync(url, content).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.Content.ReadAsStringAsync().Result);

            return response.Content.ReadAsAsync<T>().Result;
        }
    }
}
