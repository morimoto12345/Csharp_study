using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdDay_ex1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =1; i <= 9; i++)
            {
               
                for (int j = 1; j <= 9; j++)
                {
                    int k = i * j;
                    if(k <= 9)
                    {
                        Console.Write(i + "×" + j + "= " + k + " ");
                    }
                    else
                    {
                        Console.Write(i + "×" + j + "=" + k + " ");
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}
