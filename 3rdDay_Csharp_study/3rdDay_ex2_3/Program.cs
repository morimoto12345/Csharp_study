using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdDay_ex2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] nums = new int[10];
            // 配列の定義および出力
            for(int i = 0; i < nums.Length; i++)
            {
                int num = rnd.Next(1, 101);
                Console.Write($"{num} ");
                nums[i] = num;
            }
            Console.WriteLine();
            
            //並べ替え
            for(int i = 0; i <nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            foreach(int i in nums)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
