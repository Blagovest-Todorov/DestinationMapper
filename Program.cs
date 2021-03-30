using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> places = new List<string>();

            string inputText = Console.ReadLine();
            string patternPlaces = @"(=|\/)([A-Z][A-Za-z]{2,})\1";
            Regex regex = new Regex(patternPlaces);

            MatchCollection placesMatched = regex.Matches(inputText);

            int travelPoints = 0;
            Console.Write("Destinations: ");

            foreach (Match item in placesMatched)
            {
                travelPoints += item.Groups[2].Value.Length;
                //Console.Write($"{item.Groups[2].Value}, ");
                places.Add(item.Groups[2].Value);
            }

            Console.Write($"{string.Join( ", ", places)}");
            Console.WriteLine();
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
