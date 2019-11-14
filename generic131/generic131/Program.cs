using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic131
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            Employee<string> employee1 = new Employee<string>()  ;
            employee1.Things = new List<string> {"Bob", "Betty", "Billy" };
          
            foreach (string name in employee1.Things)
              Console.WriteLine(name);




            Employee<int> employee = new Employee<int>() ;
            employee.Things = new List<int> { 1, 2, 3 };

            foreach (int number in employee.Things )
                Console.WriteLine(number);
         
            
           
            Console.ReadLine();
        }
       
    }
}
