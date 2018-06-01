namespace DemoLibrary
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public class WebClient
    {
        public async Task<string> GetCountryDataAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("http://services.groupkt.com/country/get/all");

                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}