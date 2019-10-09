using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICProgram.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Person 1");

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Hourly Rate?");
            string hourRate1 = Console.ReadLine();
            int hr1 = Convert.ToInt32(hourRate1);

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Hours worked per week?");
            string weekHours1 = Console.ReadLine();
            int wh1 = Convert.ToInt32(weekHours1);

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Person 2");

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Hourly Rate?");
            string hourRate2 = Console.ReadLine();
            int hr2 = Convert.ToInt32(hourRate2);

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Hours worked per week?");
            string weekHours2 = Console.ReadLine();
            int wh2 = Convert.ToInt32(weekHours2);

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Weekly Salary of Person 1");
            int num1 = hr1;
            int num2 = wh1;
            int product = num1 * num2;
            Console.WriteLine(product);

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Weekly Salary of Person 2");
            int num3 = hr2;
            int num4 = wh2;
            int production = num3 * num4;
            Console.WriteLine(production);

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            int num5 = product;
            int num6 = production;
            bool greater = num5 > num6;
            Console.WriteLine(greater);
            Console.ReadLine();
        }
    }
}
