using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5thDay_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an array with two elements
            Data[] d = new Data[2];
            // show number of Data instance
            Data.ShowNumber();
            //create first instance
            for(int i = 0; i < d.Length; i++)
            {
                d[i] = new Data(i * 100);
                // create Data instance
                Data.ShowNumber();
            }
        }
    }
}
