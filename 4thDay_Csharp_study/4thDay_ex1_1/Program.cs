using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_ex1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.Write("Width: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double h = double.Parse(Console.ReadLine());

            double area = rectangle.GetArea(w, h);
            Console.Write("Area: ");
            Console.WriteLine($"{area}");

            double perimeter = rectangle.GetPerimeter(w, h);
            Console.Write("Perimeter: ");
            Console.WriteLine($"{perimeter}");
        }
    }
}
