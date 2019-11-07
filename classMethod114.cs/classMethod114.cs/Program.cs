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

            Math1.Number(num1: 12);

            Math1.get(num2: 12);

            string num3 = "100";
            int value = Convert.ToInt32(num3);
            Math1.Convert(value);
            Console.ReadLine();
                
        }

    }
}
