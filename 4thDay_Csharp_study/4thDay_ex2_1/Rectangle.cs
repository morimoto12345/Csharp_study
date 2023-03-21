using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDay_ex2_1
{
    class Rectangle
    {
        private double width;
        private double height;

        public double GetArea()
        {
            return width * height;
        }
        public double GetPerimater()
        {
            return 2 * (width + height);
        }

        public double Width
        {
            set { width = value; }
            get { return width; }
        }

        public double Height
        {
            set { height = value; }
            get { return height; }
        }
    }
}
