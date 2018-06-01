namespace DemoLibrary
{
    public class Country
    {
        public Country(string name, string alpha2Code, string alpha3Code)
        {
            Name = name;
            Alpha2Code = alpha2Code;
            Alpha3Code = alpha3Code;
        }

        public string Name { get; }

        public string Alpha2Code { get; }

        public string Alpha3Code { get; }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", Name, Alpha2Code, Alpha3Code);
        }
    }
}
