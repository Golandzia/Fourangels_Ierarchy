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

        public override double SquareCalculation()
        {
            Square = Sides[2] * Sqrt(Pow(Points[0].X - Points[0].X, 2) + Pow(Points[3].Y - Points[0].Y, 2));
            return Square;
        }
        public override List<double> AnglesCalculation()
        {
            Angles[0] = ((Acos((Pow(Sides[3], 2) + Pow(Sides[2], 2) - Pow(Max(Diagonals[0], Diagonals[1]), 2)) / (2 * Sides[2] * Sides[3]))) * 180) / PI;
            Angles[1] = (360 - (Angles[0] * 2)) / 2;
            Angles[2] = Angles[0];
            Angles[3] = Angles[1];
            return Angles;
        }
        public override string ToString()
        {
            string results =
                "\n\nLeight of sides:\nAB = " + Sides[0] + "\nBC = " + Sides[1] + "\nCD = " + Sides[2] + "\nDA = " + Sides[3] +
                "\n\nLeight of diagonals:\nAC = " + Diagonals[0] + "\nBD = " + Diagonals[1] +
                "\n\nPerimetr = " + Perimetr +
                "\n\nSquare = " + Square +
                "\n\nAngles:\nAngle A = " + Angles[0] + "\nB = " + Angles[1] + "\nC = " + Angles[2] + "\nD = " + Angles[3];
            return results;
        }
        public void MainParalelogram()
        {
            Paralelogram paralelogram = new Paralelogram();
            Console.WriteLine("You select a Paralelogram");
            Console.WriteLine("Enter the coordinates of points in format:\nX coordinate of point A\nY coordinate of point A \nX coordinate of point B\n etc...");
            paralelogram.SetCoordinates(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            paralelogram.LeightOfSidesCalculation();
            paralelogram.DiagonalCalculation();
            paralelogram.AnglesCalculation();
            paralelogram.SquareCalculation();
            paralelogram.PerimetrCalculation();
            Console.WriteLine(paralelogram.ToString());
        }
    }
}
