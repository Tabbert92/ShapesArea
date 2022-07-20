using System;
using ShapeAreaCalculation;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calcularor = new ShapeAreaCalculator();
            var result = calcularor.calculateArea("triangle", new List<double>() { 1, 1, 1 });
            Console.WriteLine(result);
            result = calcularor.calculateArea("circle", new List<double>() { 2 });
            Console.Write(result);
        }
    }
}