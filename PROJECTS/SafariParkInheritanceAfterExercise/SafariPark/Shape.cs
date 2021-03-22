﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public abstract class Shape
    {
        public abstract int CalculateArea();
    }

    public sealed class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public override int CalculateArea()
        {
            return _width * _height;
        }
    }
}
