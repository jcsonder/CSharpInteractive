namespace DemoClient
{
    using System;
    using DemoLibrary;

    public class Program
    {
        public static void Main(string[] args)
        {
            CountryService countryService = new CountryService(new WebClient());

            var countries = countryService.GetCountriesAsync().GetAwaiter().GetResult();
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            Console.ReadKey();
        }
    }
}