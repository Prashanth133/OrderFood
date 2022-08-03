using System;
using System.Collections.Generic;
using System.Text;

namespace OrderFood
{
    //abstract class
    abstract class RoseParkHotel 
    {
        //getters and setters
        public string Name { set; get; }
        public string Id { get; }
        public string Contact { set; get; }

        //access modifier
        private static int id = 2034;

        //constructor
        public RoseParkHotel(string name,string contact)
        {
            Name = name;
            Contact = contact;
            Id = id.ToString();
            id++;
        }
        public void BookStay(int days)
        {
            Console.WriteLine($"{Name} has booked a stay for {days} days");
        }

        //method overloading
        public void BookStay(int days,DateTime date)
        {
            Console.WriteLine($"{Name} has booked a stay of {days} days at {date} in Rose Park Hotel");
        }

        public void Checkout(DateTime date)
        {
            Console.WriteLine($"{Name} has successfullly checked out at {date}");

        }

        //abstract method
        public abstract void DisplayFoodList(List<string> foodItems);
        
    }
}
