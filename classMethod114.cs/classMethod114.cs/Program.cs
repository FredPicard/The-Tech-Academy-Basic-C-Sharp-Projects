using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethod114.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Math1 math = new Math1();
           


            int num1 = 12;
            decimal num2 = 5.5m;
            string num3 = "100";
            Console.WriteLine(math.Number(num1 ));
            Console.WriteLine(math.Number(num2));
            Console.WriteLine(math.Number(num3)) ;
            Console.ReadLine();
                
        }

    }
}
