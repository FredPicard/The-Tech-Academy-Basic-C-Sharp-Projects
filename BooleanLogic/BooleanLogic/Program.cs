using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We must first approve you for this car rental after some basic questions.");

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Have you ever had a DUI?");
            string x = Console.ReadLine();
            bool dui = Convert.ToBoolean(x);
            


            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int tickets1 = Convert.ToInt32(tickets);

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Qualified?");

            bool qualified =  (age1 > 15 && dui != true && tickets1 < 3);
            Console.WriteLine(qualified);
           




            Console.ReadLine();



        }
    }
}
