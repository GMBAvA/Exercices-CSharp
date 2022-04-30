using System;
using System.Collections.Generic;
using System.Text;

namespace Les_formes
{
    class Triangle : Forme
    {
        private bool estRectangle;

        public Triangle(Point p1, Point p2, Point p3) : this (p1, p2, p3, false)
        {

        }

        public Triangle (Point p1, Point p2, Point p3, bool estRectangle) : base (new Point[] { p1, p2, p3 })
        {

        }

    }
}
