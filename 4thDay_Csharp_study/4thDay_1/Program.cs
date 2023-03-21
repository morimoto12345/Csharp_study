using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            //create a instance of first person class
            p1 = new Person();
            //create a instance of second person class
            p2 = new Person();
            p1.name = "Yamada Taro";
            p1.age = 19;
            // set name and age in the method
            p2.SetAgeAndName("Sato Hanako", 23);
            //show name and age of each instance
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
