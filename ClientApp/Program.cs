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
            Paralelogram paralelogram = new Paralelogram();
            Console.WriteLine("Enter the coordinates of points in format:\nX coordinate of point A\nY coordinate of point A \nX coordinate of point B\n etc...");
            paralelogram.SetCoordinates(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            
            paralelogram.LeightOfSidesCalculation();
            paralelogram.DiagonalCalculation();
            paralelogram.AnglesCalculation();
            List<double> test = paralelogram.AnglesCalculation();

            foreach (double angle in test)
            {
                Console.WriteLine(angle);
            }
            Console.ReadKey();
            
        }
    }
}
