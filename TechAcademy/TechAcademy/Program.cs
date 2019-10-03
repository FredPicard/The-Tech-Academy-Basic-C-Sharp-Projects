using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            String courseName = Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNumber);
          



            Console.WriteLine("Do you need help with anything else? Please answer \"true\" or \"false\".");
            string x = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(x);


            Console.WriteLine("Were there any positive experiences you'd like to share?Please give specifics");
            string shareExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();



            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hrNum = Convert.ToInt32(hoursStudied);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
                



            Console.ReadLine();









        }
    }
}
