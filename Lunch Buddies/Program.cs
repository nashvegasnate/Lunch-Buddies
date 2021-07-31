using System;
using System.Collections.Generic;

namespace Lunch_Buddies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are my Lunch Buddies");
            var whatever = "";
            List<LunchBuddy> buddies = new List<LunchBuddy>();
            var dima = new LunchBuddy("Dima", "Potapenko");
            var per = new LunchBuddy("Per", "Gudmundsson");
            var hubert = new LunchBuddy("Hubert", "Benoit");
            var jane = new LunchBuddy("Jane", "Smith");
            buddies.Add(per);
            buddies.Add(hubert);
            buddies.Add(jane);

            whatever = dima.Eat();
            dima.Eat("borscht");
            dima.Eat(buddies);
            dima.Eat("borscht", buddies);
        }
    }
}
