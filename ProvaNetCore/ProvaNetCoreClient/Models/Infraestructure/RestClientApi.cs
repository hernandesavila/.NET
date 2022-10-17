using RestSharp;

namespace ProvaNetCoreClient.Models.Infraestructure
{
    public class RestClientApi
    {
        public static async Task<string> ExecuteGetRequest(string baseUri, string resource)
        {
            RestClient client = new RestClient(baseUri);
            var request = new RestRequest(resource);
            var response = await client.ExecuteGetAsync(request);

            if (response.IsSuccessful)
            {
                return response.Content.ToString();
            }

            return null;
        }
    }
}
