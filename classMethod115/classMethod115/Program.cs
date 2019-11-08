using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethod115
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Num = new Class1();
          
            Console.WriteLine("Please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another number if you like");
            string response = Console.ReadLine();

            if (response == "")

            {
                Console.WriteLine(Num.Number(num1));
            }
            else
            {
                int num2 = Convert.ToInt32(response);
                Console.WriteLine(Num.Number(num1,num2));

            }
           
            
            Console.ReadLine();



            

        }
    }
}
