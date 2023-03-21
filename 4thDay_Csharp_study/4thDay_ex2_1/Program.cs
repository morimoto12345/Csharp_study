using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_ex2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            // enter width and height
            Console.Write($"Width? : ");
            r.Width = double.Parse(Console.ReadLine());
            Console.Write($"Height? : ");
            r.Height = double.Parse(Console.ReadLine());

            // output
            Console.WriteLine($"Area: {r.GetArea()}");
            Console.WriteLine($"Perimeter: {r.GetPerimater()}");

        }
    }
}
