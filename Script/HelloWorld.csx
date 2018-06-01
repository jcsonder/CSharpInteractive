// Run in VS Code with OmniSharp and dotnet-script
#r "E:\Code\Repos\CSharpInteractive\CoreDemoLibrary\bin\Debug\netcoreapp2.1\CoreDemoLibrary.dll"

using CoreDemoLibrary;
using CoreDemoLibrary.Countries;

Console.WriteLine("--- START ---");

WebClient webClient = new WebClient();
CountryService service = new CountryService(webClient);

var countries = service.GetCountriesAsync().GetAwaiter().GetResult();

foreach (var item in countries)
{
    Console.WriteLine($"{item.Alpha2Code}: {item.Name}");
}

Console.WriteLine("--- END ---");