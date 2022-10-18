using RestSharp;

namespace ProvaNetCoreClient.Models.Infraestructure
{
    public class RestClientApi
    {
        public static async Task<string> ExecuteGetRequest(string baseUri, string resource)
        {
            RestClient client = new RestClient(baseUri);
            var request = new RestRequest(resource);

            request.AddHeader("Accept", "application/json");

            var response = await client.ExecuteGetAsync(request);

            if (response.IsSuccessful)
            {
                return response.Content.ToString();
            }

            return null;
        }

        public static async Task<string> ExecutePostRequest(string baseUri, string resource, object data)
        {
            RestClient client = new RestClient(baseUri);
            var request = new RestRequest(resource, Method.Post);

            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", data.ToString(), ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return response.Content.ToString();
            }

            return null;
        }

        public static async Task<string> ExecutePutRequest(string baseUri, string resource, object data)
        {
            RestClient client = new RestClient(baseUri);
            var request = new RestRequest(resource, Method.Put);

            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", data.ToString(), ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return response.Content.ToString();
            }

            return null;
        }

        public static async Task<string> ExecuteDeleteRequest(string baseUri, string resource)
        {
            RestClient client = new RestClient(baseUri);
            var request = new RestRequest(resource, Method.Delete);

            request.AddHeader("Accept", "application/json");

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return response.Content.ToString();
            }

            return null;
        }
    }
}
