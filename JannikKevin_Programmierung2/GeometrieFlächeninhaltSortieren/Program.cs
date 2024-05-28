using System;
using System.Collections.Generic;
using GeometrieFlächeninhaltSortieren.GeometrieFlächeninhaltSortieren;

namespace GeometrieFlächeninhaltSortieren
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CShape> shapes = new List<CShape>
            {
                new CCircle(1),
                new CRectangel(200),
                new CCircle(120),
                new CRectangel(50)
            };

            shapes.Sort();

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape: {shape.GetType().Name}, Surface: {shape.Surface}");
            }
        }
    }
}