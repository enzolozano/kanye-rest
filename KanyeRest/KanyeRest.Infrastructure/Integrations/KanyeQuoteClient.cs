using System.Text.Json;

namespace KanyeRest.Infrastructure.Integrations
{
    public class KanyeQuoteClient : IKanyeQuoteClient
    {
        private readonly HttpClient _httpClient;

        private readonly string _urlKanyeWestQuoteApi = "https://api.kanye.rest/";

        public KanyeQuoteClient() 
        { 
            _httpClient = new HttpClient();
        }

        public async Task<string> GetRandomQuoteAsync()
        {
            var response = await _httpClient.GetStringAsync(_urlKanyeWestQuoteApi);
            var json = JsonDocument.Parse(response);

            return json.RootElement
                .GetProperty("quote")
                .ToString();
        }
    }
}
