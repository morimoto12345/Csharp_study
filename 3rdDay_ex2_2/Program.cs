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
            int[] num = new int[]; 
            int[] odd = new int[9];
            int[] even = new int[9];
            for (int i = 0; i <= 9; i++)
            {
                int num_rnd = rnd.Next(1, 101);
                Console.Write(num + " ");
                num[i] = num_rnd;

                if (num_rnd % 2 == 0)
                {
                    foreach (int j in num)
                    {
                        even[j] = num_rnd;
                    }
                } 
                else if(num_rnd % 2 == 1)
                {
                    foreach (int j in num)
                    {
                        odd[j] = num_rnd;
                    }
                }
                
            }
            foreach(int i in odd)
            {
                Console.WriteLine("奇数：", odd[i]);
            }
            foreach (int i in even)
            {
                Console.WriteLine("奇数：", even[i]);
            }

            
        }
    }
}
