using System;
using System.Collections.Generic;
using System.Text;

namespace Les_formes
{
    class Forme
    {
        private List<Point> points;

        public Forme()
        {
            points = new List<Point>();
        }

        public Forme(Point[] points)
        {
            this.points = new List<Point>(points);
        }

        public override string ToString()
        {
            bool premierPoint = true;
            string info = "Forme {";
            foreach (Point point in points)
            {
                if (premierPoint)
                    premierPoint = false;
                else
                    info += ",";
                info += point;
            }
            info += "}";
            return info;
        }
    }
}
