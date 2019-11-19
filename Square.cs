using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPart10_ClassAndObject
{
    class Square
    {
        public string name;
        private int width;
        private int height;

        public void SetDimension(int w,int h) 
        {
            width = w;
            height = h;
        }
        public int CalculateArea()
        {
            return width * height;
        }

    }
}
