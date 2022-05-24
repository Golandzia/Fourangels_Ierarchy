using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Fourangels_Ierarchy
{
    public class ConvexQuadrilateral
    {
        private double perimetr, square;
        public List<double> Sides = new List<double> {new double(), new double(), new double(), new double() };
        public List<double> Diagonals = new List<double> { new double(), new double() };
        public List<double> Angles = new List<double> { new double(), new double(), new double(), new double() };
        public List<Point> Points = new List<Point>
        {
            new Point(),
            new Point(),
            new Point(),
            new Point()
        };
        public double Perimetr
        {
            get { return perimetr; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Value " + value + " can't be seted as a perimetr of this quadriterial");
                else perimetr = value;
            }
        }
        public double Square
        {
            get { return square; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Value " + value + " can't be seted as a square of this quadriterial");
                else square = value;
            }
        }



        public void SetCoordinates(double xa, double ya, double xb, double yb, double xc, double yc, double xd, double yd)
        {
            Points[0].X = xa;
            Points[0].Y = ya;
            Points[1].X = xb;
            Points[1].Y = yb;
            Points[2].X = xc;
            Points[2].Y = yc;
            Points[3].X = xd;
            Points[3].Y = yd;
        }


        public List<double> LeightOfSidesCalculation()
        {
            Sides[0] = (Sqrt(Pow(Points[1].X - Points[0].X, 2) + Pow(Points[1].Y - Points[0].Y, 2)));
            Sides[1] = (Sqrt(Pow(Points[2].X - Points[1].X, 2) + Pow(Points[2].Y - Points[1].Y, 2)));
            Sides[2] = (Sqrt(Pow(Points[3].X - Points[2].X, 2) + Pow(Points[3].Y - Points[2].Y, 2)));
            Sides[3] = (Sqrt(Pow(Points[3].X - Points[0].X, 2) + Pow(Points[3].Y - Points[0].Y, 2)));
            return Sides;
        }
        protected double PerimetrCalculation()
        {
            Perimetr = Sides[0] + Sides[1] + Sides[2] + Sides[3];
            return Perimetr;
        }
        public List<double> DiagonalCalculation()
        {
            Diagonals[0] = (Sqrt(Pow(Points[2].X - Points[0].X, 2) + Pow(Points[2].Y - Points[0].Y, 2)));
            Diagonals[1] = (Sqrt(Pow(Points[3].X - Points[1].X, 2) + Pow(Points[3].Y - Points[1].Y, 2)));
            return Diagonals;
        }
        public virtual double SquareCalculation()
        {
            double HalfPerimetr = Perimetr / 2;
            Square = Sqrt((HalfPerimetr - Sides[0]) * (HalfPerimetr - Sides[1]) * (HalfPerimetr - Sides[2]) * (HalfPerimetr - Sides[3]));
            return Square;
        }
        public virtual List<double> AnglesCalculation()
        {
            Console.WriteLine("Фурмулы нахождения углов выпуклого четырехугольника НЕ СУЩЕСТВУЕТ! ");
            return Angles;
        }
    }
}