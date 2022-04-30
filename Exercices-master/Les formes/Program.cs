using System;

namespace Les_formes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ETAPE #1 : Les points");

            Point p1 = new Point(1, 1);
            Point p2 = new Point(3, 1);
            Point p3 = new Point(3, 4);
            Point p4 = new Point(1, 4);
            Point p5 = new Point();

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine(p5);

            Console.WriteLine("\nETAPE #2 : Les formes");

            Forme f1 = new Forme();
            Console.WriteLine("f1 : " + f1);

            Forme f2 = new Forme(new Point[] 
            {
                p5, new Point(6, 9)
            });
            Console.WriteLine("f2 : " + f2);



            Console.WriteLine("\nETAPE #3 : Les rectangles");

            Rectangle f3 = new Rectangle(p1, p3);
            Console.WriteLine("f3 : " + f3);

            Rectangle f4 = new Rectangle(p1, p2, p3, p4);
            Console.WriteLine("f4 : " + f4);

            Rectangle f5 = new Rectangle(p1, 2, 3);
            Console.WriteLine("f5 : " + f5);



            Console.WriteLine("\nETAPE #4 : Les triangles");

            Triangle f6 = new Triangle(p1, p2, p3, true);
            Console.WriteLine("f6 : " + f6);

            Triangle f7 = new Triangle(p1, p2, new Point(34, 34));
            Console.WriteLine("f7 : " + f7);
        }
    }
}
