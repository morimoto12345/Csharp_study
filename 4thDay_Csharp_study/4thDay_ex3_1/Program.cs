using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_ex3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] students = new Students[3];
            //store data of student
            students[0] = new Students("Koki", 3, 18);
            students[1] = new Students("Yuchi", 2, 17);
            students[2] = new Students("Hanako", 1, 16);
        }
    }
}
