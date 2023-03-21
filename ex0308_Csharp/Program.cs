using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex0308_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int max = 0;
            int min = 100;
            int avg = 0;
            int sum = 0;
            Random rnd = new Random();
            // 1以上7未満の乱数を発生させる（1から6まで）
            foreach (int i in num)
            {
                int num_rnd = rnd.Next(1, 101);
                Console.Write($"{num_rnd} ");
                if(max <= num_rnd)
                {
                    max = num_rnd;
                }
                
                if(min >= num_rnd)
                {
                    min = num_rnd;
                }

                sum += num_rnd;
            }
            Console.WriteLine();
            avg = sum / 10;
            Console.WriteLine($"最大値：{max}");
            Console.WriteLine($"最小値：{min}");
            Console.WriteLine($"合計値：{sum}");
            Console.WriteLine($"平均値：{avg}");

        }
    }
}
