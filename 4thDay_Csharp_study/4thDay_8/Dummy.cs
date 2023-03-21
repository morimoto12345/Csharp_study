using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_8
{
    class Dummy
    {
        // constructor
        public Dummy()
        {
            Console.WriteLine($"constructor");
        }

        // destructor
        ~Dummy()
        {
            Console.WriteLine($"destructor");
        }
    }
}
