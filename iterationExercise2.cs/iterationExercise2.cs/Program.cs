using System;
using System.Collections.Generic;

namespace iterationExercise2.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            //#9 & 10
            Console.WriteLine("Please type in Squash, Cucumbers, Onions, Sprouts, or Lettuce");
            List<string> veggies = new List<string> { "Squash", "Cucumbers", "Onions", "Sprouts", "Squash", "Lettuce" };
            string veg = (Console.ReadLine());


            bool found = false;
            for (int i = 0; i < veggies.Count; i++)
            {
                if (veggies[i] == veg)
                {
                    found = true;
                    Console.WriteLine(i);
                }

            }
            if (found == false)
            {
                Console.WriteLine("Not a valid entry");
                
            }
         
        
      
    















        //#11
        String[] colors = new String[] { "red", "blue", "green", "red", "purple", "yellow", "red", "blue" };
        //String[] array = new String[colors.Length];
        List<String> distinct = new List<string>();
                    foreach (string colour in colors)
                    {
                        Console.Write(colour);

                        if (distinct.Contains(colour))
                        {
                            Console.Write($" <-- This color is repeated");
                        }
                        else
                        {
                            distinct.Add(colour);
                        }
                
                        Console.WriteLine();



                    }
                    Console.ReadLine();

                }
            }
        }
