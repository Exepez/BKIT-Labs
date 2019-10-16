﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Square: Rectangle, IPrint
    {
        public Square(double A) : base(A, A)
        {
            Type = "Квадрат";
        }
        public Square() : base()
        {
            Type = "Квадрат";
        }
    }
}