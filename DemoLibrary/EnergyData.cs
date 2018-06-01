using System.Net.Http;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class EnergyData
    {
        public static async Task<string> GetCountries()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("http://services.groupkt.com/country/get/all");

                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}