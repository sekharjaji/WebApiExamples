using System.Net.Http;
using System.Net.Http.Headers;

namespace BasicWebApiFormatters.FunctionalTests
{
    public class ApiServiceClient : HttpClient
    {
        public ApiServiceClient()
        {
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
        }
    }
}
