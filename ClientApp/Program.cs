using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fourangels_Ierarchy;
namespace ClientApp
{
    internal class Program
    {
        static void Main()
        {
            UserIsStupid: Console.WriteLine("Select a figure\n1.Paralelogram\n2.Romb\n3.Square\n4.Convex quadriterial\n" +
                "To select a figure write her number end press <Enter>");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("You select a Paralelogram");
                    Console.WriteLine("Enter the coordinates of points in format:\nX coordinate of point A\nY coordinate of point A \nX coordinate of point B\n etc...");
                    Paralelogram paralelogram = new Paralelogram(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                        Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                        Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    paralelogram.LeightOfSidesCalculation();
                    paralelogram.DiagonalCalculation();
                    paralelogram.AnglesCalculation();
                    paralelogram.SquareCalculation();
                    paralelogram.PerimetrCalculation();
                    Console.WriteLine(paralelogram.ToString());
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("You select a Romb");
                    Console.WriteLine("Enter the coordinates of points in format:\nX coordinate of point A\nY coordinate of point A \nX coordinate of point B\n etc...");
                    Romb romb = new Romb(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                        Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                        Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    romb.LeightOfSidesCalculation();
                    romb.DiagonalCalculation();
                    romb.AnglesCalculation();
                    romb.SquareCalculation();
                    romb.PerimetrCalculation();
                    Console.WriteLine(romb.ToString());
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("You select a Square");
                    Console.WriteLine("Enter the coordinates of points in format:\nX coordinate of point A\nY coordinate of point A \nX coordinate of point B\n etc...");
                    Square square = new Square(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                        Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                        Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    square.LeightOfSidesCalculation();
                    square.DiagonalCalculation();
                    square.AnglesCalculation();
                    square.SquareCalculation();
                    square.PerimetrCalculation();
                    Console.WriteLine(square.ToString());
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("You select a Square");
                    Console.WriteLine("Enter the coordinates of points in format:\nX coordinate of point A\nY coordinate of point A \nX coordinate of point B\n etc...");
                    ConvexQuadrilateral convexQuadriterial = new ConvexQuadrilateral(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                        Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                        Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    convexQuadriterial.LeightOfSidesCalculation();
                    convexQuadriterial.DiagonalCalculation();
                    convexQuadriterial.AnglesCalculation();
                    convexQuadriterial.SquareCalculation();
                    convexQuadriterial.PerimetrCalculation();
                    Console.WriteLine(convexQuadriterial.ToString());
                    break;
                default: 
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Select 1, 2 or 3 !");
                    Console.BackgroundColor = ConsoleColor.Black;
                         goto UserIsStupid;
            }
            Console.ReadKey();
        }
    }
}
