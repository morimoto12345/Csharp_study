using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdDay_ex1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("正の整数を入力：");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
