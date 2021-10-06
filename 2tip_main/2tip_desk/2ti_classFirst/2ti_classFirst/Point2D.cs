using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ti_classFirst
{
    public class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point2D() {
            X = 0;
            Y = 0;
        }

        public Point2D(double x, double y) {
            X = x;
            Y = y;
        }

        public override string ToString() {
            return $"({X}, {Y})";
        }

        public double Distance() {
            return Math.Sqrt(X * X + Y * Y);
        }

        public double Distance(Point2D p) {
            return Math.Sqrt((X - p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y));
        }
        public static Point2D operator +(Point2D p1, Point2D p2) {
            return new Point2D(p1.X + p2.X, p1.Y+p2.Y);
        }
        // Con.....(p1+p2)
        ~Point2D() {
            Console.WriteLine("Czyszczenie obiektu");
        }
    }
}
