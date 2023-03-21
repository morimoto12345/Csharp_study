using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_ex1_1
{
    class Rectangle
    {
        public double GetArea(double width, double height)
        {
            return  width * height;
        }
        public double GetPerimeter(double width, double height)
        {
            return 2 * (width + height);
        }
    }
}
