using Newtonsoft.Json.Linq;
using NozzleQuiz.Integrations.NozzleSoft.Serializer;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NozzleQuiz.Integrations.NozzleSoft.Api
{
    public class BaseApi
    {
        public static async Task<IRestResponse<JToken>> PostMethodAsync(string uri, Dictionary<string, string> headers = null, object requestObject = null)
        {
            var client = new RestClient(uri);
            var request = new RestRequest(Method.POST) { RequestFormat = DataFormat.Json };
            var result = await GetResultAsync(client, request, requestObject, headers);

            return result;
        }

        public static async Task<IRestResponse<JToken>> GetMethodAsync(string uri, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(uri);
            var request = new RestRequest(Method.GET) { RequestFormat = DataFormat.Json };
            var result = await GetResultAsync(client, request, null, headers);

            return result;
        }

        public static async Task<IRestResponse<JToken>> PutMethodAsync(object requestObject, string baseUri, string uri, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(uri);
            var request = new RestRequest(Method.PUT) { RequestFormat = DataFormat.Json };
            var result = await GetResultAsync(client, request, requestObject, headers);

            return result;
        }

        public static async Task<IRestResponse<JToken>> DeleteMethodAsync(string uri, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(uri);
            var request = new RestRequest(Method.DELETE) { RequestFormat = DataFormat.Json };
            var result = await GetResultAsync(client, request, null, headers);

            return result;
        }


        private static async Task<IRestResponse<JToken>> GetResultAsync(RestClient client, RestRequest request, object requestObject = null, Dictionary<string, string> headers = null)
        {
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }

            if (requestObject != null)
            {
                request.AddJsonBody(requestObject);
            }

            client.UseSerializer<NewtonsoftJsonSerializer>();

            var response = await client.ExecuteAsync<JToken>(request);

            return response;
        }

    }
}
