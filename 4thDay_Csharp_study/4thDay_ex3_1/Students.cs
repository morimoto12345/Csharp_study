using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_ex3_1
{
    class Students
    {
        // name
        private string name;
        // grade
        private int grade;
        //age
        private int age;

        // constructor
        public Students(string name, int grade, int age)
        {
            this.name = name;
            this.grade = grade;
            this.age = age;
            Console.WriteLine($"name:{name}, grade:{grade}, age:{age}");
        }
        /*
        //set information of students
        public void SetInformation(string name,int grade, int age)
        {
            this.name = name;
            this.grade = grade;
            this.age = age;
        }
        
        
        // show information of students
        public void ShowInformation()
        {
            Console.WriteLine($"name:{name}, grade:{grade}, age:{age}");
        }
        */
    }
}
