using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Fourangels_Ierarchy
{
    public class Paralelogram : ConvexQuadrilateral
    {
        
        //public override double SquareCalculation()
        //{
        //    Square = Sides[0] * Sides[1] *
        //    return Square;
        //}

        

        public override List<double> AnglesCalculation()
        {
            double LongerDiagonal;
            
            Angles[0] = ((Acos((Pow(Sides[3], 2) + Pow(Sides[2], 2) - Pow(Max(Diagonals[0], Diagonals[1]), 2)) / (2 * Sides[2] * Sides[3]))) * 180) / PI;
            Angles[1] = (360 - (Angles[0] * 2)) / 2;
            Angles[2] = Angles[0];
            Angles[3] = Angles[1];
            return Angles;
        }
    }
}
