using System;

namespace Countries_Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Dave\Desktop\Coding Class\pluralsight\C-Collections\CsCollectionsPluralsight\src\csharp-collections-beginning\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{country.population}: {country.name}");
            }
        }
    }
}
