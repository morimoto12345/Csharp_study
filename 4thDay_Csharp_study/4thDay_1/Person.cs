using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_1
{
    class Person
    {
        // 名前(フィールド)
        public string name = "";
        // 名前(フィールド)
        public int age = 0;
        // 情報の表示(メソッド)
        public void ShowAgeAndName()
        {
            Console.WriteLine($"name:{name}, age:{age}");
        }
       public void SetAgeAndName(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

    }
}
