namespace CoreDemoLibrary.Countries
{
    using Newtonsoft.Json;

    public class Country
    {
        public Country(string name, string alpha2Code, string alpha3Code)
        {
            Name = name;
            Alpha2Code = alpha2Code;
            Alpha3Code = alpha3Code;
        }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; }

        [JsonProperty(PropertyName = "alpha2_code")]
        public string Alpha2Code { get; }

        [JsonProperty(PropertyName = "alpha3_code")]
        public string Alpha3Code { get; }

        public override string ToString()
        {
            return $"{Name}-{Alpha2Code}-{Alpha3Code}";
        }
    }
}
