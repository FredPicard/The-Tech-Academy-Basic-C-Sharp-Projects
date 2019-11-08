using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethod114.cs
{
    class Math1
    {

      
       public int Number(int num1)
        {
            return (num1 * 12);

        }

        public int Number(decimal num2)
        {
            return Convert.ToInt32(num2 + 5);
        }

        public int Number(string num3)
        {
            return Convert.ToInt32(num3) * 5;
        }





    }

    
}
