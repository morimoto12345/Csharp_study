using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_ex1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter English sentence: ");
            string sentence = Console.ReadLine();
            Console.Write($"English sentence in lower case: ");
            Console.WriteLine($"{sentence.ToLower()}");
            Console.Write($"English sentence in upper case: ");
            Console.WriteLine($"{sentence.ToUpper()}");
        }
    }
}
