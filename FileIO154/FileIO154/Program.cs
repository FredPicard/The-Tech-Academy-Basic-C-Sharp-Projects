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
            }

           

            using (StreamReader sr = File.OpenText(file1))
            {
                string s;
                while ((s = sr.ReadLine()) !=null)
                {
                    Console.Out.WriteLine(s);
                }
              
            }





                Console.ReadLine();
            }

        } 
    }
