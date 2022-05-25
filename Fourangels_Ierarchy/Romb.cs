using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Fourangels_Ierarchy
{
    public class Romb : ConvexQuadrilateral
    {
        public override List<double> AnglesCalculation()
        {
            Angles[0] = ((Acos((Pow(Max(Diagonals[0], Diagonals[1]), 2) / (2 * Pow(Sides[0], 2)))-1)) * 180) / PI;
            Angles[1] = (360 - (Angles[0] * 2)) / 2;
            Angles[2] = Angles[0];
            Angles[3] = Angles[1];
            return Angles;
        }
        public override double SquareCalculation()
        {
            Square = (Diagonals[0] * Diagonals[1]) / 2;
            return Square;
        }
        public Romb(double xa, double ya, double xb, double yb, double xc, double yc, double xd, double yd)
        {
            Points[0].X = xa;
            Points[0].Y = ya;
            Points[1].X = xb;
            Points[1].Y = yb;
            Points[2].X = xc;
            Points[2].Y = yc;
            Points[3].X = xd;
            Points[3].Y = yd;
            LeightOfSidesCalculation();
            if (Sides[0] <= 0 || Sides[1] <= 0 || Sides[2] <= 0 || Sides[3] <= 0)
            {
                Console.WriteLine("This is no such Romb");
                Console.ReadKey();
            }
        }
        public Romb() { }
    }
}
