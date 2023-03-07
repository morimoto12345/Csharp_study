using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdDay_ex1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 11);
            Console.WriteLine("数あてゲーム");
            Console.Write("0から10の数値を入力してください");
            int i = 1;
            while(i <= 3)
            {
                Console.Write("{0}回目:", i);
                int j = int.Parse(Console.ReadLine());
                if (j == num)
                {
                    Console.WriteLine("正解です");
                    break;
                }
                else if (num < i)
                {
                    Console.WriteLine("大きすぎます");
                }
                else
                {
                    Console.WriteLine("小さすぎます");
                }

                if(i == 3)
                {
                    Console.WriteLine("ゲームオーバーです");
                    Console.WriteLine("正解は{0}です", num);
                }
                i++;
            }
        }
    }
}
