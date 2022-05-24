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
            UserIsStupid: Console.WriteLine("Select a figure\n1.Paralelogram\n2.Romb\n3.Square\nTo select a figure write her number end press <Enter>");
            short UserSelect = Convert.ToInt16(Console.ReadLine());
            switch (UserSelect)
            {
                case 1:
                    Paralelogram paralelogram = new Paralelogram();
                    paralelogram.MainParalelogram();
                    break;
                case 2:
                    Romb romb = new Romb();
                    romb.MainRomb();
                    break;
                case 3:
                    Square square = new Square();
                    square.MainSquare();
                    break;
                default: Console.WriteLine("Select 1, 2 or 3 !");
                         goto UserIsStupid;
                    break;
            }
            Console.ReadKey();
        }
    }
}
