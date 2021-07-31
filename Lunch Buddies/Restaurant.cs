using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunch_Buddies
{
    class Restaurant
    {
        private List<string> Names { get; set; } = new List<string>();
        public string Name { get; set; }

        public Restaurant()
        {
            Names.Add("Bill's Grill");
            Names.Add("Ellie's Deli");
            Names.Add("Fish-R-Us");

            Random rnd = new Random();
            int randomRestaurant = rnd.Next(0, Names.Count);
            Name = Names[randomRestaurant];
        }
    }
}
