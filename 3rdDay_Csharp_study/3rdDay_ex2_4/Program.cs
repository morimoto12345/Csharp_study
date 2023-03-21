using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdDay_ex2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                int num = rnd.Next(1, 100);
                Console.Write($"{num} ");
                nums[i] = num;
            }
            Console.WriteLine();

            for(int i = 0; i<nums.Length; i++)
            {
                Console.Write($"{i*10}以上{i*10+10}未満：");
                foreach (int j in nums)
                {
                    if (j < i*10+10 && i*10 <= j)
                    {
                        Console.Write($"{j} ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
