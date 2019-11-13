using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractVirtual124
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }


        public new void SayName()
        {
            throw new NotImplementedException();

        }

        public void Quittable()
        {
            //throw new NotImplementedException();
        }

        public static bool operator ==(Employee E1, Employee E2)
        {

            if (E1.Id == E2.Id) 

            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public static bool operator !=(Employee E1, Employee E2)
        {
            if (E1.Id != E2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    }
