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
    }
}
