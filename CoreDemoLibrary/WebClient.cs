using System.Net.Http;
using System.Threading.Tasks;

namespace CoreDemoLibrary
{
    public class WebClient
    {
        public async Task<string> GetCountryDataAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);

                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
