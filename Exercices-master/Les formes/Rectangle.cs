using System;
using System.Collections.Generic;
using System.Text;

namespace Les_formes
{
    class Rectangle : Forme
    {
        public Rectangle(Point p1, Point p3) : base (new Point[] { p1, p3, new Point(p1.GetX(), p3.GetY()), new Point (p3.GetX(), p1.GetY())})
        {}

        public Rectangle(Point p1, Point p2, Point p3, Point p4) : base (new Point[] { p1, p2, p3,p4})
        {}

        public Rectangle(Point p1, int longueur, int largeur)
            : base(new Point[] { p1, new Point(p1.GetX() + longueur, p1.GetY()),
            new Point (p1.GetX() + longueur, p1.GetY() + largeur),
            new Point (p1.GetX(), p1.GetY() + largeur)})
        {}
    }
}
