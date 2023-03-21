using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdDay_ex2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.Write("1つ目の数字: ");
            int num_first = int.Parse(Console.ReadLine());
            a[0] = num_first;
            int min = num_first;
            int max = num_first;

            for (int i = 1; i <= 4; i++)
            {
                Console.Write(i + 1 + "つ目の数字: ");
                int num = int.Parse(Console.ReadLine());
                a[i] = num;
                if (num >= max)
                {
                    max = num;
                }else if (num <= min)
                {
                    min = num;
                }
            }

            foreach(int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("最大値は" + max);
            Console.WriteLine("最小値は" + min);



            /* Maxメソッドを使った場合
            int[] a = new int[5]; 
            for(int i = 0; i <= 4; i++)
            {
                Console.Write(i + 1 + "つ目の数字: ");
                int num = int.Parse(Console.ReadLine());
                a[i] = num;
            }
            int max = a.Max();
            int min = a.Min();

            Console.WriteLine("最大値：" + max);
            Console.WriteLine("最小値：" + min);

            */
        }
    }
}
