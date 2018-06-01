namespace CoreDemoLibrary.Countries
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    // generated with help of: http://json2csharp.com/
    public class RestResponse
    {
        public RestResponse(IList<string> messages, IList<Country> countries)
        {
            Messages = messages;
            Countries = countries;
        }

        [JsonProperty(PropertyName = "messages")]
        public IList<string> Messages { get; }

        [JsonProperty(PropertyName = "result")]
        public IList<Country> Countries { get; }
    }
}
