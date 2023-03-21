using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_ex2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter text: ");
            string text = Console.ReadLine();
            Console.Write($"Number of words is: ");
            Console.WriteLine($"{text.Length}");
        }
    }
}
