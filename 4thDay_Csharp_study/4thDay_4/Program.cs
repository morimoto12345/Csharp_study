﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Access a = new Access();
            //a.Data1 = 1;
            a.Data2 = 2;
            a.ShowDatas();
            Console.WriteLine($"a.Data1 = {a.Data1}");
            // Console.WriteLine($"a.Data2 = {a.Data2}");


        }
    }
}
