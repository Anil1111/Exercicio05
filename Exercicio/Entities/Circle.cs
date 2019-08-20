using Exercicio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Entities
{
    class Circle : Shape
    {
        const double Pi = 3.14;

        public double Radius { get; set; }

        public Circle() { }

        public Circle(Color color, double radius) : base(color) => Radius = radius;

        public override double Area() => Pi * (Radius * Radius);
    }
}
