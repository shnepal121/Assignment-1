using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
                       
      

            Console.WriteLine("The below program displays 3 numbers in Descending Order");
            int highest = int.MinValue;
            bool IsNumber == false; 

            for (int i = 1; i < 4; i++)
            {

                while (!IsNumber)
                {

                    try
                    {
                        Console.WriteLine("Enter Order" + i.ToString() + " Number:");
                        string input = Console.ReadLine();
                        decimal number = Convert.ToDecimal(input);
                        Isnumber = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Re-enter the number:" + e.Message);                       
                    }
                


                if (number > highest)
                {
                    highest = number;
                }

                }
                Console.WriteLine("The Highest of the Number was" + highest.ToString()); 

            }

            /*
            Console.WriteLine("Enter First Number");
            string First_Number = Console.ReadLine();
            int A = Convert.ToInt32(First_Number);

            Console.WriteLine("Enter Second Number");
            string Second_Number = Console.ReadLine();
            int B = Convert.ToInt32(Second_Number);

            Console.WriteLine("Enter Third Number");
            string Third_Number = Console.ReadLine();
            int C = Convert.ToInt32(Third_Number);

            int D = A - B;
            Console.WriteLine("The Three Numbers were" + A+", "+ B+", "+ C + " And Diff of First and Second was: " + D);
            */

            Console.ReadLine();
        }
    }
}
