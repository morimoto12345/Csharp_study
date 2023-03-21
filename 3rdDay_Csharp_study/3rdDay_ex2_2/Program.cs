using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdDay_ex2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] num = new int[10];
            for (int i =0;i<10; i++)
            {
                int num_rnd = rnd.Next(1, 101);
                Console.Write($"{num_rnd} ");
                num[i] = num_rnd;
            }
            Console.WriteLine();

            Console.Write($"奇数：");
            foreach (int i in num)
            {
                if (i % 2 == 1)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();

            Console.Write($"偶数：");
            foreach (int i in num)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine(); 
        }
    }
}
