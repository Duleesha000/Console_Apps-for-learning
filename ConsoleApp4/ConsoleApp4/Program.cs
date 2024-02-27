using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Rectangle
    {
        
            float length;
            float width;
            float area;

            public void setData()
            {
                Console.WriteLine("Enter Value for length:");
                length = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Value for width:");
                width = float.Parse(Console.ReadLine());
            }

            public void displayData()
            {
                Console.WriteLine("Length:" + length);
                Console.WriteLine("Width:" + width);
                

                Console.WriteLine("Area:" + area);
            }

            public void calArea()
            {
                area = length * width;
            }



            
        

      
    }

    class Program {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.setData();
            r1.calArea();
            r1.displayData();
            Console.ReadKey();
        }
    }
}
