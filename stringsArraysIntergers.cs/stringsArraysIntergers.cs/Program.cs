using System;
using System.Collections.Generic;


namespace stringsArraysIntergers.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number between 0 & 3");
            string[] names = { "Bobby", "Betty", "Billy", "Bonnie" };
            string name = (Console.ReadLine());
            int name1 = Convert.ToInt32(name);
            Console.WriteLine(names[name1]);

            Console.WriteLine("Choose a  number 0 through 5 do discover its index");
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            array[5] = 6;
            int numbers = int.Parse(Console.ReadLine());
                if (numbers > 6)
                {
                    Console.WriteLine("Sorry that index does not exist");
                }
                else
                {
                    Console.WriteLine(array[numbers]);
                }
            Console.WriteLine("Select an index of 0 through 4 to see how we say hello in a diferent language");
            List<string> mylist = new List<string>(new string[] { "Hello= English", "Hola= Spanish", "as-salam = Persian", "Ciao= Italian", "Bonjour= French" });
            string hello = (Console.ReadLine());
            int hello1 = Convert.ToInt32(hello);
            Console.WriteLine(mylist[hello1]);



            Console.ReadLine();
            }

        }

       
          
        }
    

