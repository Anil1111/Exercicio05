﻿using Exercicio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() { }

        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area() => Width * Height;
    }
}
