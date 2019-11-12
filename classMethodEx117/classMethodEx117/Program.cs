using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethodEx117
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello Num = new Hello();

            Console.WriteLine("Please Enter A Number");
            int input = Convert.ToInt32(Console.ReadLine());
            int output;
            Num.Number(input , out output);
            Console.WriteLine(output);


            Console.ReadLine();

        }
          

    }
}
