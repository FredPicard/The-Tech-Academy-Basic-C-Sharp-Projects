using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMath.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            //multiplying user input by 50

            Console.WriteLine("Please enter a number");
            int first = Convert.ToInt32(Console.ReadLine());
            int num1 = first;
            int num2 = 50;
            double product = num1 * num2;
            Console.WriteLine(product);
            Console.ReadLine();

            //adding 25 to user input

            Console.WriteLine("Please enter a number");
            int second = Convert.ToInt32(Console.ReadLine());
            int num3 = first;
            int num4 = 25;
            int add = num3 + num4;
            Console.WriteLine(add);
            Console.ReadLine();


            //divides input from the user by 12.5

            Console.WriteLine("Please enter a number");
            int third = Convert.ToInt32(Console.ReadLine());
            int num5 = first;
            float num6 = 12.5f;
            float divide = num5 / num6;
            Console.WriteLine(divide);
            Console.ReadLine();

            //takes imput from user and checks to see if greater than 50

            Console.WriteLine("Please enter a number");
            int fourth = Convert.ToInt32(Console.ReadLine());
            int num7 = fourth;
            int num8 = 50;
            bool greater = num7 > num8;
            Console.WriteLine(greater);
            Console.ReadLine();

            //takes input from the user, divides that by 7 and prints the remainder

            Console.WriteLine("Please enter a number");
            int fifth = Convert.ToInt32(Console.ReadLine());
            int num9 = fifth;
            int num10 = 7;
            int remainder = num9 % num10;
            Console.WriteLine(remainder);
            Console.ReadLine();

        }
    }
}
