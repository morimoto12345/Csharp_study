using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdDay_ex2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] nums = new int[5, 5];
            //　要素に数字を入れていく
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    nums[i, j] = i * 5 + j + 1;
                }
            }

            // それぞれの要素をランダムに入れ替える
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int k = rnd.Next(1, 5);
                    int l = rnd.Next(1, 5);
                    int temp = nums[k,j];
                    nums[i, j] = nums[k,l];
                    nums[i, j] = temp;
                }

            }
            //表を作成
            for (int i = 0; i < 5; i++)
            {
                Console.Write("|");
                for (int j = 0; j < 5; j++)
                {
                    if (nums[i, j] < 10)
                    {
                        Console.Write($" {nums[i, j]}|");
                    }
                    else
                    {
                        Console.Write($"{nums[i, j]}|");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("_______________");
            }
        }
    }
}
