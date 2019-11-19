using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime156
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number ");
           int num = Convert.ToInt32(Console.ReadLine());
           var combinedTime = DateTime.Now. AddHours(num);
           Console.WriteLine(combinedTime);
            Console.ReadLine();
        } 
    }
}
