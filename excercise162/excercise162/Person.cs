using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise162
{
   public class Person
    {
        public Person() : this(10)
        {
            
        }

        public Person(int Age)
        {
            Console.WriteLine(Age);
        }
    }
}
