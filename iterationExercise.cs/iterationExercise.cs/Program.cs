using System;
using System.Collections.Generic;


namespace iterationExercise.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1
            Console.WriteLine("Please enter your name");
            string[] greeting = { "Hello", "Hola", "as-salam", "Ciao", "Bonjour" };
            string greeting1 = (Console.ReadLine());

            foreach (string i in greeting)
            {
                Console.WriteLine(i + greeting1);
            }
            System.Threading.Thread.Sleep(2000);
            foreach (string j in greeting)
            {
                Console.WriteLine(j);
            }


            //infinite loop #2&3

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("How we say hello in 5 languages");
                {
                    break;
                }



            }
            System.Threading.Thread.Sleep(2000);
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine(" This is a < operator iteration: {0}", i);
            }
            System.Threading.Thread.Sleep(2000);
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine(" This is a <= operator iteration: {0}", i);
            }


            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Choose Bobby,Betty, Billy or Bonnie");
            List<string> names = new List<string> { "Bobby", "Betty", "Billy", "Bonnie" };
            string name2 = (Console.ReadLine());
            int index = names.FindIndex(a => a.Contains(name2));

            if (names.Contains(name2))
            {
                Console.WriteLine(+index + (name2));
            }
            else
            {
                Console.WriteLine("Sorry thats not a choice");
            }




            System.Threading.Thread.Sleep(2000);

            List<string> color = new List<string> { "red", "blue", "green", "red", "purple", "yellow" };

            foreach (string colours in color)
            {
                Console.WriteLine(colours);

                if (colours.Contains("red"))
                {

                    Console.WriteLine($"This color is repeated twice");
                }




            }
            Console.ReadLine();
        }
       

    }

}





























         
        
    

        


            
        

               
              
        
    

          


    
  
           
        





     
       

  
