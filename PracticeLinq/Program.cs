using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameGames = new List<string>() {"Halo", "Halo 2", "Skyrim", "World of Warcraft" };

            nameGames.OrderByDescending(x => x.Length);
            nameGames.ForEach(x => Console.WriteLine(x));
            
        }
    }
}
