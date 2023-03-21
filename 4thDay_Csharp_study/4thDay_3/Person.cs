using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_3
{
    class Person
    {
        // name(field)
        private string name = "";
        // age(field)
        private int age = 0;
        // set information
        public void SetAgeAndName(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        // show information
        public void ShowAgeAndName()
        {
            Console.WriteLine($"name: {name}, age: {age}");
        }
        //set information
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        // set information
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }
}
