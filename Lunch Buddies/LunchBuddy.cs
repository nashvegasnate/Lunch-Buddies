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

        //public string Eat()
        //{
          //  Console.WriteLine("$")
        //}
    }
}
