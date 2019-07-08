using System;
using System.Collections.Generic;
using System.Linq;

namespace Countries_Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Dave\Desktop\Coding Class\pluralsight\C-Collections\CsCollectionsPluralsight\src\csharp-collections-beginning\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            Dictionary<string,List<Country>> countries = reader.ReadAllCountries();

            foreach (string region in countries.Keys)
                Console.WriteLine(region);

            Console.Write("which region do you want to display?");

            string chosenRegion = Console.ReadLine();

            if (countries.ContainsKey(chosenRegion))
            {
                foreach(Country country in countries[chosenRegion].Take(10))
                {
                    Console.WriteLine($"{country.population}: {country.name}");
                }
            }

            //foreach(Country country in countries.OrderBy(x=> x.name).Take(10))
            //{
            //    Console.WriteLine($"{country.population}: {country.name}");
            //}

            //lync methods
            //var filteredCountries = countries.Where(x => !x.name.Contains(','));//.Take(20);
            ////query syntax
            //var filteredCountries2 = from country in countries
            //                         where !country.name.Contains(',')
            //                         select country;

            //foreach (Country country in filteredCountries.Take(25)) 
            //{
            //    Console.WriteLine($"{country.population}: {country.name}");
            //}
            
            //Dictionary<string, Country> countries = reader.ReadAllCountries();
            //Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2000000);
            //int lilliputIndex = countries.FindIndex(x => x.population < 2000000);
            //countries.Insert(lilliputIndex, lilliput);
            //countries.RemoveAt(lilliputIndex);

            //string userInput = Console.ReadLine();

            //bool gotCountry = countries.TryGetValue(userInput, out Country country);
            //if(!gotCountry)
            //{
            //    Console.WriteLine($"Sorry, there is no country with code, {userInput}");
            //}
            //else
            //     Console.WriteLine($"{country.name} has population {country.population}");

            //Console.Write("enter no. of Countries to display>");
            //bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            //if (!inputIsInt || userInput <= 0)
            //{
            //    Console.WriteLine("you must type in a +ve interger. Exiting");
            //    return;
            //}


            //int maxToDisplay = userInput;

            //List<Country> countries = reader.ReadAllCountries();

            //for (int i = 0; i < countries.Count; i++)
            //{
            //    if (i > 0 && (i % maxToDisplay == 0))
            //    {
            //        Console.WriteLine("Hit return to continue, anything else will quit>");
            //        if (Console.ReadLine() != "")
            //            break;
            //    }
            //    Country country = countries[i];
            //    Console.WriteLine($"{i + 1}: {country.population}: {country.name}");
            //}

            //for (int i = countries.Count -1; i >= 0; i--)
            //{
            //    int j = countries.Count - 1 - i;
            //    if (j > 0 && (j % maxToDisplay == 0))
            //    {
            //        Console.WriteLine("Hit return to continue, anything else will quit>");
            //        if (Console.ReadLine() != "")
            //            break;
            //    }
            //    Country country = countries[i];
            //    Console.WriteLine($"{j + 1}: {country.population}: {country.name}");

            //}



        }
    }
}
