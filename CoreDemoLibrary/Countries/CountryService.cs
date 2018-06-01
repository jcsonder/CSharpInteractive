namespace CoreDemoLibrary.Countries
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class CountryService
    {
        const string url = "http://services.groupkt.com/country/get/all";

        private readonly WebClient _webClient;

        public CountryService(WebClient webClient)
        {
            _webClient = webClient;
        }

        public async Task<IList<Country>> GetCountriesAsync()
        {
            var rawCountryData = await _webClient.GetCountryDataAsync(url);
            var response = JsonConvert.DeserializeObject<RootObject>(rawCountryData);

            return response.RestResponse.Countries;
        }
    }
}
