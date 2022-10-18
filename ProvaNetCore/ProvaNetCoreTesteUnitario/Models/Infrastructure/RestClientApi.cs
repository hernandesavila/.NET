using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaNetCoreTesteUnitario.Infrastructure
{
    internal class RestClientApi
    {
        public static async Task<RestResponse> ExecuteGetRequest(string baseUri, string resource)
        {
            RestClient client = new RestClient(baseUri);
            var request = new RestRequest(resource);

            request.AddHeader("Accept", "application/json");

            var response = await client.ExecuteGetAsync(request);

            return response;
        }

        public static async Task<RestResponse> ExecutePostRequest(string baseUri, string resource, object data)
        {
            RestClient client = new RestClient(baseUri);
            var request = new RestRequest(resource, Method.Post);

            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", data.ToString(), ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            var response = await client.ExecuteAsync(request);

            return response;
        }

        public static async Task<RestResponse> ExecutePutRequest(string baseUri, string resource, object data)
        {
            RestClient client = new RestClient(baseUri);
            var request = new RestRequest(resource, Method.Put);

            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", data.ToString(), ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            var response = await client.ExecuteAsync(request);

            return response;
        }

        public static async Task<RestResponse> ExecuteDeleteRequest(string baseUri, string resource)
        {
            RestClient client = new RestClient(baseUri);
            var request = new RestRequest(resource, Method.Delete);

            request.AddHeader("Accept", "application/json");

            var response = await client.ExecuteAsync(request);

            return response;
        }
    }

}
