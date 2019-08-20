using Exercicio.Entities;
using Exercicio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data entry
            Console.Write("Enter the number of shapes: ");
            int number = int.Parse(Console.ReadLine());

            char type;
            Color color;
            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"\nShape #{i} data: ");

                Console.Write("Rectangle or Circle (r/c)? ");
                type = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red)? ");
                color = Enum.Parse<Color>(Console.ReadLine());

                if (type == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Circle(color, radius));
                }
            }


            //Data output
            Console.WriteLine("\nSHAPE AREAS: ");
            foreach (Shape item in shapes)
                Console.WriteLine(item);
        }
    }
}
