﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndDay_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("さいころの目(1～6)：");
            int dice = int.Parse(Console.ReadLine());
            if(1 <= dice && dice <= 6)
            {
                if(dice%2 == 0)
                {
                    Console.WriteLine("丁です");
                }
                else
                {
                    Console.WriteLine("半です");
                }
            }
            else
            {
                Console.WriteLine("範囲内の数値です");
            }
        }
    }
}
