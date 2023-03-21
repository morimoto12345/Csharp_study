using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdDay_ex1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num_1 = rnd.Next(1, 101);
            Console.Write(num_1 + " ");
            int num_max = num_1;
            int num_min = num_1;
            for (int i = 2; i <= 10; i++)
            {
                int num = rnd.Next(1, 101);
                Console.Write(num + " ");
                if (num >= num_max)
                {
                    num_max = num;
                }else if (num <= num_min)
                {
                    num_min = num;
                }
            }
            Console.WriteLine();
            Console.WriteLine("最大値："+ num_max);
            Console.WriteLine("最小値：" + num_min);




            Console.WriteLine();
        }
    }
}
