using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndDay_ex2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("月(1～12)を入力してください。");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("{0}月の長さは31です。", month);
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("{0}月の長さは30です。", month);
                    break;

                case 2:
                    Console.WriteLine("2月の長さは28か29です。");
                    break;

                default:
                    Console.WriteLine("範囲外の数値です。");
                    break;

            }
        }
    }
}
