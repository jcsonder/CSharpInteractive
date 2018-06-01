namespace DemoClient
{
    using System;
    using DemoLibrary;

    public class Program
    {
        public static void Main(string[] args)
        {
            var energyDemandRaw = EnergyData.GetCountries().Result;
            Console.WriteLine("Raw Data:");
            Console.WriteLine(energyDemandRaw.Substring(1, 1000) + "...");

            Console.ReadKey();
        }
    }
}