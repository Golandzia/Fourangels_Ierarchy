using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourangels_Ierarchy
{
    public class Square : ConvexQuadrilateral
    {
        public override List<double> AnglesCalculation()
        {
            Angles[0] = 90;
            Angles[1] = 90;
            Angles[2] = 90;
            Angles[3] = 90;
            return Angles;
        }
        public override double SquareCalculation()
        {
            Square = Sides[0] * Sides[0];
            return Square;
        }
        public Square(double xa, double ya, double xb, double yb, double xc, double yc, double xd, double yd)
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
            PerimetrCalculation();
            SquareCalculation();
            if (Square <= 0)
            {
                exist = false;
            }
            else exist = true;
        }
        public Square() { }
    }
}
