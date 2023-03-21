using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_ex3_2
{
    class Hoo
    {
        public Hoo()
        {
            Console.WriteLine($"Hooのインスタンスが生成されました");
        }
        public void Foo()
        {
            Console.WriteLine($"Fooのメソッドが実行されました");
        }
        ~Hoo()
        {
            Console.WriteLine($"Hooのインスタンスが消去されました");
        }
    }
}
