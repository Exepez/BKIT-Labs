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
        public override string ToString() { return this.Type + " площадью " + this.Area().ToString(); }
    }
}