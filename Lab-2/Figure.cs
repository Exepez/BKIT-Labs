using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    abstract class Figure
    {
        abstract public double Area();
        public string Type { get; protected set; }
        abstract public string ToString();
    }
}