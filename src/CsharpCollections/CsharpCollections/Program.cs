using System;

namespace CsharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysofWeek =
            {
                "Monday",
                "Tuesday",
                "Wensday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            daysofWeek[2] = "Wednesday";

            foreach (string day in daysofWeek)
                Console.WriteLine(day);

            //Console.WriteLine("Which Day do you want?");
            //Console.Write("(Monday = 1, etc. > ");
            //int iDay = int.Parse(Console.ReadLine());

            //string chosenDay = daysofWeek[iDay - 1];
            //Console.WriteLine($"That day is {chosenDay}");


        }
    }
}
