using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPkg.cs
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Please enter your package weight:");
            int weight = int.Parse (Console.ReadLine());
            int weight1 = Convert.ToInt32(weight);


            if (weight1 > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
               
            }

            int width = int.Parse (Console.ReadLine());
            int width1 = Convert.ToInt32(width);

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Please enter the package height:");
            int height = int.Parse(Console.ReadLine());
            int height1 = Convert.ToInt32(height);

            if (width1 + height1 > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
            }
            else
            {
                Console.WriteLine("Please enter the package length:");
               
            }


            int length = int.Parse (Console.ReadLine());
            int length1 = Convert.ToInt32(length);




            float area = (float)(width1 + height1 + length1) * (float)(weight1) / 100;
            Console.WriteLine("Your estimated total for shipping this package is : $" + area + Environment.NewLine + "Thank you.");
            Console.ReadKey();

            Console.ReadLine();
        }

    }
}
