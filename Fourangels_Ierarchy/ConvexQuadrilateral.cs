using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;//Почему не работает без "static" ?

namespace Fourangels_Ierarchy
{
    class ConvexQuadrilateral : Point
    {
        private double leightA, leightB, leightC, leightD;
        private double angleA, angleB, angleC, angleD;
        private double perimetr, square;
        protected double Perimetr
        {
            get { return perimetr; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Value " + value + " can't be seted as a perimetr of this quadriterial");
                else perimetr = value;
            }
        }
        protected double Square
        {
            get { return square; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Value " + value + " can't be seted as a square of this quadriterial");
                else square = value;
            }
        }
        protected double LeightA
        {
            get { return leightA; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Vallue " + " Can't be seted as leight of side A");
                else leightA = value;
            }
        }
        protected double LeightB
        {
            get { return leightB; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Vallue " + " Can't be seted as leight of side B");
                else leightB = value;
            }
        }
        protected double LeightC
        {
            get { return leightC; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Vallue " + " Can't be seted as leight of side C");
                else leightC = value;
            }
        }
        protected double LeightD
        {
            get { return leightD; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Vallue " + " Can't be seted as leight of side D");
                else leightD = value;
            }
        }
        protected double AngelA
        {
            get { return angleA; }
            set
            {
                if(value<0)
                    Console.WriteLine("Value " + value + " can't be seted as degree value of angle A");
                else angleA = value;
            }
        }
        protected double AngelB
        {
            get { return angleB; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Value " + value + " can't be seted as degree value of angle B");
                else angleB = value;
            }
        }
        protected double AngelC
        {
            get { return angleC; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Value " + value + " can't be seted as degree value of angle C");
                else angleC = value;
            }
        }
        protected double AngelD
        {
            get { return angleD; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Value " + value + " can't be seted as degree value of angle D");
                else angleD = value;
            }
        }
        public void LeightOfSidesCalculation(double xa, double ya, double xb, double yb, double xc, double yc, double xd, double yd)
        {
            LeightA = Sqrt(Pow(xb - xa, 2) + Pow(yb - ya, 2));
            LeightB = Sqrt(Pow(xc - xb, 2) + Pow(yc - yb, 2));
            LeightC = Sqrt(Pow(xd - xc, 2) + Pow(yd - yc, 2));
            LeightD = Sqrt(Pow(xd - xa, 2) + Pow(yd - ya, 2));
        }
        public void PerimetrCalculation()
        {
            Perimetr = LeightA + LeightB + LeightC + LeightD;
        }
        protected override void DiagonalCalculation()
        {

        }

    }
}