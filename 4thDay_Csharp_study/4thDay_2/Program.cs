﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            int a = 1, b = 2, c = 3;
            int ans1 = calc.Add(a, b);
            int ans2 = calc.Add(a, b, c);
            Console.WriteLine($"{a} + {b} = {ans1}");
            Console.WriteLine($"{a} + {b} + {c} = {ans2}");

        }
    }
}
