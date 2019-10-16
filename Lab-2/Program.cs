using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Гришин Илья ИУ5-32Б";
            Rectangle rct = new Rectangle();
            Rectangle rct1 = new Rectangle(3,65);
            Square sqr = new Square();
            Square sqr1 = new Square(3);
            Circle cir = new Circle();
            Circle cir1 = new Circle(5);
            rct.PropA = 24;
            rct.PropB = 10;
            sqr.PropA = 10;
            sqr.PropB = 10;
            cir.PropR = 7;

            // Display results.
            rct.I_Print();
            rct1.I_Print();
            sqr.I_Print();
            sqr1.I_Print();
            cir.I_Print();
            cir1.I_Print();
            Console.ReadKey();
        }
    }
}
