using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBasics.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Hello,";
            string y = "My name is ";
            string z = x + y +"Fred \n\n\n";
            string upperZ = z.ToUpper();
            Console.WriteLine(upperZ);

            StringBuilder sb = new StringBuilder("\"Tell all the truth but tell it slant\", by Emily Dickinson \n\n\t");

            sb.Append("Tell all the truth but tell it slant \n\t");
            sb.Append("Success in circuit lies \n\t");
            sb.Append("Too bright for our infirm Delight\n\t");
            sb.Append("The Truth's superb surprise\n\t");
            sb.Append("As Lightening to the Children eased\n\t");
            sb.Append("With explanation kind\n\t");
            sb.Append("The Truth must dazzle gradually \n\t");
            sb.Append("Or every man be blind-");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
      
    }
}
