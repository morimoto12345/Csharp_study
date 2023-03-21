using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdDay_ex1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* for文
            Console.Write("★の数を入力");
            int star = int.Parse(Console.ReadLine());
            for (int i = 1; i<= star; i++)
            {
                Console.WriteLine("★");
            }
            */


            /* while文
            Console.Write("★の数を入力");
            int star = int.Parse(Console.ReadLine());
            int i = 1;
            while(i <= star)
            {
                Console.Write("★");
                i++;
            }
            Console.WriteLine();
            */


            /* do while文
            Console.Write("★の数を入力");
            int star = int.Parse(Console.ReadLine());
            int i = 1;
            do
            {
                Console.Write("★");
                i++;

            }
            while (i <= star) ;
            Console.WriteLine();
            */
        }
    }
}
