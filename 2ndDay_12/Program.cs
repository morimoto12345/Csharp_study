using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndDay_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("さいころの目(1～6)：");
            int dice = int.Parse(Console.ReadLine());
            switch (dice)
            {
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("半です");
                    break;
                case 2:
                case 4:
                case 6:
                    Console.WriteLine("丁です");
                    break;
            }
        }
    }
}
