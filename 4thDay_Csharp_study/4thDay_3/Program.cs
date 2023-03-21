using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            // create a instance of first Person class method
            p1 = new Person();
            // create a instance of second Person class method
            p2 = new Person();
            p1.Name = "Yamada Taro";  //substitute values for field name
            p1.Age = 19;  //substitute values for field age
            // set name and age 
            p2.SetAgeAndName("Sato Hanako", 23);
            // show name and age by method
            p1.ShowAgeAndName();
            // show name and age by property
            Console.WriteLine($"name: {p2.Name}, age: {p2.Age}");

        }
    }
}
