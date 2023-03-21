using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_5
{
    class Person2
    {
        // set information
        public void SetAgeAndName(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // show information(method)
        public void ShowAgeAndName()
        {
            Console.WriteLine($"name: {Name}, age: {Age}");
        }
        // set information
        public string Name
        {
            private set; get;
        }
        //set information
        public int Age
        {
            set; get;
        }
    }
}
