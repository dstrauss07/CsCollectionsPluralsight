using System;
using System.Collections.Generic;

namespace Countries_Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Dave\Desktop\Coding Class\pluralsight\C-Collections\CsCollectionsPluralsight\src\csharp-collections-beginning\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            Dictionary<string, Country> countries = reader.ReadAllCountries();
            //Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2000000);
            //int lilliputIndex = countries.FindIndex(x => x.population < 2000000);
            //countries.Insert(lilliputIndex, lilliput);
            //countries.RemoveAt(lilliputIndex);

            string userInput = Console.ReadLine();

            bool gotCountry = countries.TryGetValue(userInput, out Country country);
            if(!gotCountry)
            {
                Console.WriteLine($"Sorry, there is no country with code, {userInput}");
            }
            else
                 Console.WriteLine($"{country.name} has population {country.population}");
            
        }
    }
}
