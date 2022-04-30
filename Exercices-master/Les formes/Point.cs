using System;
using System.Collections.Generic;
using System.Text;

namespace Les_formes
{
    class Point
    {
        private int x;
        private int y;

        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public override string ToString()
        {
            return "Point {x:" + x + ", y:" + y + "}";
        }
    }
}
