using System;
using System.Collections.Generic;

namespace OrderFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Your contact: ");
            string contact = Console.ReadLine();



            Console.Write("No. of days stay: ");
            int days = int.Parse(Console.ReadLine());

            Restaurant booking = new Restaurant(name, contact);
            booking.BookStay(days, DateTime.Now);

            Console.WriteLine("Do you want to checkout Y/N?");
            var ch = Console.ReadLine();
            if (ch == "Y" || ch == "y")
            { 
                booking.Checkout(DateTime.Now);
                return;
            }
            //collections
            var items = new List<string> { "Paneer Tikka Naan,Lemon Rice, Tomato Soup"};

            Console.WriteLine("Do you want to add food?Y/N:");
            ch = Console.ReadLine();


            if (ch == "Y" || ch == "y")
            {
                booking.DisplayFoodList(items);
            }
            else return;


        }

        
        
    }
}
