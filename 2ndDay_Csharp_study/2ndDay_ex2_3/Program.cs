using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndDay_ex2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("H20の温度:");
            double a = double.Parse(Console.ReadLine());
            if( a >= 100)
            {
                Console.WriteLine("気体");
            }else if (a <= 0)
            {
                Console.WriteLine("固体");
            }
            else
            {
                Console.WriteLine("液体");
            }
        }
    }
}
