using System;
using System.Collections.Generic;
using ShapeAreaCalculation;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calcularor = new ShapeAreaCalculator();

            var result = calcularor.СalculateArea("triangle", new List<double>() { 1, 1, 1 });
            Console.WriteLine(result);

            result = calcularor.СalculateArea("circle", new List<double>() { 2 });
            Console.Write(result);
        }
    }
}