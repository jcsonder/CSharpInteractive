namespace DemoLibrary
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Script.Serialization;

    public class CountryService
    {
        private readonly WebClient _webClient;

        public CountryService(WebClient webClient)
        {
            _webClient = webClient;
        }

        public async Task<IList<Country>> GetCountriesAsync()
        {
            var rawCountryData = await _webClient.GetCountryDataAsync();

            var serializer = new JavaScriptSerializer();
            var countryData = serializer.Deserialize<dynamic>(rawCountryData);

            var response = countryData["RestResponse"];
            var result = response["result"];

            var countries = new List<Country>();
            foreach (var item in result)
            {
                countries.Add(new Country(item["name"], item["alpha2_code"], item["alpha3_code"]));
            }

            return countries;
        }
    }
}
