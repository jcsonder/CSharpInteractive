#r "System.Web.Extensions"
#r ".\bin\Debug\DemoLibrary.dll"

using DemoLibrary;
using System.Web.Script.Serialization;

var countriesRaw = (await CountryData.GetCountries());
Console.WriteLine(countriesRaw.Substring(1, 100) + "...");
