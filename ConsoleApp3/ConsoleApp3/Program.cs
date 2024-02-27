using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            float total;

            Console.WriteLine("Type a number, and then press Enter");
            float no1 =float.Parse(Console.ReadLine());
            Console.WriteLine("Write another number, and then press Enter");
            float no2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:" +
                                "a-Add " +
                                "s-Subtract" +
                                "m-Multiply" +
                                "d-Divide");
            String option = Console.ReadLine();

            if (option == "a")
            {
                total = no1 + no2;
                Console.WriteLine("Addition of two numbers =" + total);
            }
            else if (option == "s")
            {
                total = no1 - no2;
                Console.WriteLine("Substraction of to numbers =" + total);
            }
            else if (option == "m")
            {
                total = no1 * no2;
                Console.WriteLine("Multipication of two nubers =" + total);

            }
            else if (option == "d")
            {
                total = no1 / no2;
                Console.WriteLine("Division of two numbrs =" + total);
            }
            else
            { 
                Console.WriteLine("Your Option is wrong");
            }

            Console.ReadKey();
               
            
        }
    }
}
