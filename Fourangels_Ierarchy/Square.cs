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
        public void MainSquare()
        {
            Square square = new Square();
            Console.WriteLine("You select a Square");
            Console.WriteLine("Enter the coordinates of points in format:\nX coordinate of point A\nY coordinate of point A \nX coordinate of point B\n etc...");
            square.SetCoordinates(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            square.LeightOfSidesCalculation();
            square.DiagonalCalculation();
            square.AnglesCalculation();
            square.SquareCalculation();
            square.PerimetrCalculation();
            Console.WriteLine(square.ToString());
        }
    }
}
