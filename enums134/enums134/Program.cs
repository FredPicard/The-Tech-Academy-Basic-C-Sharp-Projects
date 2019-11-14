using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums134
{
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
          
            Console.WriteLine("Please enter a day of the week");
            string day = (Console.ReadLine());
            Console.WriteLine(day);

            DaysOfTheWeek days;
            try
            {
                days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day);
           
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");

                
            }

           

            Console.ReadLine();
                
        }
    }
}
