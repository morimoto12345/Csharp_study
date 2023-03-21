using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_6
{
    class Person
    {
        //field name
        private string name = "";
        //field age
        private int age = 0;
        // constructor(no argument)
        public Person() :this("no name", 0)
        {
            Console.WriteLine("no argument construcor");
        }
        // constructpr (argument)
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine($"argument constructor name:{name} age: {age}");
        }
        // show information
        public void ShowAgeAndName()
        {
            Console.WriteLine($"name:{name} age:{age}");
        }

        //name property
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        // age property
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }
}