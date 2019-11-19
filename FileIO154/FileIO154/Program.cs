using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO154
{
    class Program
    {
        static void Main(string[] args)
        {



           
            string file1 = "C:\\Users\\Student\\Logs\\log.txt";
            Console.WriteLine("please enter a number");
            string num = Console.ReadLine();
            using (StreamWriter file = new StreamWriter("C:\\Users\\Student\\Logs\\log.txt", true))
            {
                file.WriteLine(num);
                Console.WriteLine(file1);
            }


              
            


            Console.ReadLine();
            }

        } 
    }
