using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> gameList = new List<string>() {"Halo", "Call of Duty", "Forza", "Rust"};

            var newOrder = gameList.OrderByDescending(x => x.Length);

            Console.WriteLine("Here are the games in order by length:");
            foreach(var game in newOrder)
            {
                Console.WriteLine(game);
            }
            Console.ReadLine();
        }
       
    }
}
