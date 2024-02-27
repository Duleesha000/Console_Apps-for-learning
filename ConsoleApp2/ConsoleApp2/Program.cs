using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           Console.WriteLine("What is your Name?");
           String name = Console.ReadLine();

            Console.WriteLine("What is your index Number?");
            String index = Console.ReadLine();

            Console.WriteLine("Welcome "+name);
            Console.WriteLine("Your Index Number is " + index);

            Console.ReadKey();

        }
    }
}
