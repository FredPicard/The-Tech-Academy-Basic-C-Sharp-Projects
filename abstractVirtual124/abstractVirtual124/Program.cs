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
            Employee employee = new Employee();
            person.FirstName = "Sample";
            person.LastName = "Student";
            employee.Id = 6;
          

           // person.SayName();


            IQuittable quit = new Employee();
            quit.Quittable();



            Employee E1 = new Employee() { Id = 5 };
            Employee E2 = new Employee() { Id = 5 };
            Console.WriteLine(E1 == E2);


            Console.ReadLine();
        }
    }
}
