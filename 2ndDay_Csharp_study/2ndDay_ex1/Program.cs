﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndDay_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a + b ={0}", a + b);
            Console.WriteLine("a - b ={0}", a - b);
            Console.WriteLine("a * b ={0}", a * b);
            Console.WriteLine("a / b ={0}", a / b);
            Console.WriteLine("a % b ={0}", a % b);
        }
    }
}
