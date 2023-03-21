using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5thDay_1
{
    class Data
    {
        //number of Data object
        private static int num = 0;
        // value of data
        private int id;
        // constructor(argument)
        public Data(int id)
        {
            this.id = id;
            num++;
            Console.WriteLine($"value:{this.id} number:{num}");
        }
        // get number of object
        public static void ShowNumber()
        {
            Console.WriteLine($"number of objects:{num}");
        }
    }
}
