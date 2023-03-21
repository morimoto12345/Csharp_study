using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person2 p = new Person2();
            // set name and age
            p.SetAgeAndName("Yamada Taro", 26);
            // change age
            p.Age = 32;
            Console.WriteLine($"name: {p.Name}, age: {p.Age}");

        }
    }
}
