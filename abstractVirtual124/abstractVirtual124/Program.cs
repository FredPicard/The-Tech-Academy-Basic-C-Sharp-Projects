using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractVirtual124
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Employee();
            person.FirstName = "Sample";
            person.LastName = "Student";
            person.SayName();



            IQuittable quit = new Employee();
            quit.Quit();




            Console.ReadLine();
        }
    }
}
