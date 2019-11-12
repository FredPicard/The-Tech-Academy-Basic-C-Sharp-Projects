using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractVirtual124
{
    class Employee : Person, IQuittable
    {

        

        public new void SayName()
        {
            throw new NotImplementedException();
           
        }

       public void  Quit()
        {
         
        }
    }
}
