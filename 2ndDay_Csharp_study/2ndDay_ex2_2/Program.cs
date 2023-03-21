using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndDay_ex2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列を入力");
            string word = Console.ReadLine();
            if (word == "Hello")
            {
                Console.WriteLine("Helloが入力されました。");
            }
            else
            {
                Console.WriteLine("Helloと入力してください。");

            }
        }
    }
}
