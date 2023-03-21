using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_4
{
    class Access
    {
        // read only data
        private int data1 = 5;
        // write only data
        private int data2 = 0;
        // show datas
        public void ShowDatas()
        {
            Console.WriteLine($"data1={data1}, data2={data2}");

        }
        // property of data1(read-only)
        public int Data1
        {
            get { return data1; }
        }
        // property of data1(read-only)
        public int Data2
        {
           set { data2 = value; }
        }

    }
}
