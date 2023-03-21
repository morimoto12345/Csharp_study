using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person(); // no argument
            p2 = new Person("Ota takashi", 29); // argument
            p1.Name = "Saito Hanako";
            p1.Age = 18;
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
