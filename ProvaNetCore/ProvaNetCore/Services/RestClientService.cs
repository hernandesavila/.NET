using RestSharp;

namespace ProvaNetCore.Services
{
    public class RestClientService
    {
        public async Task<string> ExecuteGetRequest(string baseUri, string resource)
        {
            RestClient client = new RestClient(baseUri);
            var request = new RestRequest(resource);
            var response = await client.ExecuteGetAsync(request);
            
            if(response.IsSuccessful)
            {
                return response.Content.ToString();
            }

            return null;
        }
    }
}
