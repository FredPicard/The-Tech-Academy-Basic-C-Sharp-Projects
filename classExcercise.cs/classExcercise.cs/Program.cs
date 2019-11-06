using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classExcercise.cs
{
    class Program
    {
        private static void Main(string[] args)

        {
            Calculator Number = new Calculator();

            int num1 = 2;
            Console.WriteLine("Please enter a number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( Number.Add(num1, num2) );
            Console.WriteLine(Number.Multiply(num1, num2));
            Console.WriteLine(Number.Subtract(num1, num2));
            Console.ReadLine();
           
        }
    
    }
}
