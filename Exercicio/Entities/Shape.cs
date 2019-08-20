using Exercicio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape() { }

        public Shape(Color color) => Color = color;

        public abstract double Area();

        public override string ToString() => Area().ToString("F2", CultureInfo.InvariantCulture);
    }
}
