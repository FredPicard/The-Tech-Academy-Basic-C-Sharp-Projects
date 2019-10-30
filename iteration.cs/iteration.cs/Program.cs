using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 60, 87, 56, 100, 77, 67 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}


            //    string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //    for (int j = 0; j < names.Length; j++)
            //    {
            //        if (names[j] == "Jesse")
            //        {
            //            Console.WriteLine(names[j]);
            //        }
            //    }

            //    Console.ReadLine();
            //List<int> testScores = new List<int>();
            //testScores.Add(99);
            //testScores.Add(66);
            //testScores.Add(88);
            //testScores.Add(78);
            //testScores.Add(97);
            //testScores.Add(80);


            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + score);
            //    }
            //}
            //Console.ReadLine();


            //List<string> names = new List<string>() { "Jesse", "Erik", "Daniel", "Adam" };

            //foreach (string name in names)
            //{
            //    if (name == "Jesse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 12, 55, 34, 88 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
