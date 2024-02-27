using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Cube
    {
        float area;
        float volume;
        public void calculate(float length, float width) 
        {
            area = length * width;
            Console.WriteLine("Area of the Cube ="+ area);
        }

        public void calculate(float length, float width,float height)
        {
            volume = length * width * height;
            Console.WriteLine("Volume of the Cube =" + volume);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Cube c1 = new Cube();
            c1.calculate(10, 20);
            c1.calculate(10, 20, 30);

            Console.ReadKey();  
        }
    }
}
