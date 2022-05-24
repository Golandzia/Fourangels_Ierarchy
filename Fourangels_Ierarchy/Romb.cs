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

    }
}
