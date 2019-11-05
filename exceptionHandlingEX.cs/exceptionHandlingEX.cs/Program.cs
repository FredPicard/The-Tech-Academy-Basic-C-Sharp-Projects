using System;

namespace exceptionHandlingEX.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int[] num1 = { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine("Choose a  number ");
            decimal num2 = Convert.ToInt32(Console.ReadLine());

                foreach (int x in num1)

                {

                    Console.WriteLine(x / num2);
                }

                    Console.ReadLine();
                }
                catch (DivideByZeroException ex)

                {
                    Console.WriteLine("Cannot divide by zero");


                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Thats not a number");

                }

                catch (Exception ex)
                {

                    Console.WriteLine(ex);
                }


          

            Console.WriteLine("Done");
            Console.ReadLine();
        }

      


        }
    }
            
            


        
    
    


             
           
      
   

            
    
                              

          
            

               
            
        
          
    



          