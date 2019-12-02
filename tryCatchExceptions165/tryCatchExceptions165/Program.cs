using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchExceptions165
{
    class Program
    {


        static void Main(string[] args)
        {



            try 
            {

                //AgeException zeroage = new AgeException("NO zero");
                //AgeException negage = new AgeException("No negative numbers");


                Console.WriteLine("Please enter your age");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age == 0)
                {
                    throw new AgeException("NO zeros");
                }
                if (age < 0)
                {
                    throw new AgeException("NO negative numbers");
                }

                int dob = 2019 - age;
                Console.WriteLine(dob);
                }

                catch(AgeException a)
                {
                    Console.WriteLine(a.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Thats not a number");
                }
            
                  
          
                
                
            


              


                Console.ReadLine();




            }

            }
    }
























































