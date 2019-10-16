using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Rectangle : Figure, IPrint
    {
        public Rectangle(double propA, double propB)
        {
            PropA = propA;
            PropB = propB;
            Type = "Прямоугольник";
        }
        public Rectangle()
        {
            Type = "Прямоугольник";
        }
        public double PropA { get; set; }
        public double PropB { get; set; }
        public override double Area()
        {
            return PropA * PropB;
        }

        public void I_Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
