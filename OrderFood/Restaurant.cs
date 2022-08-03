using System;
using System.Collections.Generic;
using System.Text;

namespace OrderFood
{
    //inheritance
    class Restaurant : RoseParkHotel
    {
        //calling the base contructor
        public Restaurant(string name, string contact) : base(name, contact) { }


        //method overriding
        public override void DisplayFoodList(List<string> items)
        {
            Console.WriteLine("The list of food items added:");

            //loops
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
