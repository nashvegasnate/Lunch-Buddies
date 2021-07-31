using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunch_Buddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Restaurant Eatery { get; set; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Eatery = new Restaurant();
        }

        public string Eat()
        {
            Console.WriteLine($"{FirstName} {LastName} is eating at {Eatery.Name}.");
            return Eatery.Name;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office.");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var returnString = $"{FirstName} {LastName} is eating at {Eatery.Name} with ";
            for(var i = 0; i < companions.Count; i++)
            {
                if (i < companions.Count - 1)
                {
                    returnString += $"{companions[i].FirstName}, ";
                }
                else
                {
                    returnString += $"and {companions[i].FirstName}.";
                }
            }
            Console.WriteLine(returnString);
        }
        public void Eat(string food, List<LunchBuddy> companions)
        {
            var returnString = $"{FirstName} {LastName} ate at {Eatery.Name} and ordered the {food} with ";
            for (var i = 0; i < companions.Count; i++) 
            {
                if (i < companions.Count - 1)
                    {
                        returnString += $"{companions[i].FirstName}, ";
                    }
                    else
                    {
                        returnString += $"and {companions[i].FirstName}.";
                    }
            }
            Console.WriteLine(returnString);
        }
    }
}
