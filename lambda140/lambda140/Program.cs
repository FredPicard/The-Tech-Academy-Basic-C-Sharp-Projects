using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda140
{
    class Program
    {
        static void Main(string[] args)

        {


            List<Employee> employee = new List<Employee>();

            employee.Add(new Employee { FName = "Joe", LName = "Smith", Id = 1 });
            employee.Add(new Employee { FName = "Joe", LName = "Jordan", Id = 2 });
            employee.Add(new Employee { FName = "June", LName = "Clever", Id = 3 });
            employee.Add(new Employee { FName = "Craig", LName = "Andrews", Id = 4 });
            employee.Add(new Employee { FName = "Rich", LName = "Harrelson", Id = 5 });
            employee.Add(new Employee { FName = "Julio", LName = "Cordero", Id = 6 });
            employee.Add(new Employee { FName = "Stacy", LName = "Murray", Id = 7 });
            employee.Add(new Employee { FName = "Bill", LName = "Bellhamy", Id = 8 });
            employee.Add(new Employee { FName = "Jim", LName = "Hnedrix", Id = 9 });
            employee.Add(new Employee { FName = "Janice", LName = "Joplin", Id = 10 });

            List<Employee> Joe = new List<Employee>();
           

            //foreach (var emp in employee)
            //{
            //    if (emp.FName == "Joe")
            //        Joe.Add(emp);

            //      Console.WriteLine("{0} {1} {2}", emp.FName, emp.LName, emp.Id);

               


            //    Console.ReadLine();
            //}



            List<Employee> Joe1;

            Joe1 = employee.Where(x => x.FName == "Joe").ToList();


            List<Employee> Greater;
            Greater = employee.Where(x => x.Id > 5).ToList();

           



            Console.ReadLine();
        }

    }
}
     

       