using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourangels_Ierarchy
{
    public class Point
    {
        private double x, y;
        public double X
        {
            get { return x; }
            set
            {
                if (value < -100 || value > 100)
                    Console.WriteLine("Value " + value + "Can't be seted for X coordinate");
                else x = value;
            }
        }
        public double Y
        {
            get { return y; }
            set
            {
                if (value < -100 || value > 100)
                    Console.WriteLine("Value " + value + "Can't be seted for Y coordinate");
                else y = value;
            }
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Point() { }

    }
}
