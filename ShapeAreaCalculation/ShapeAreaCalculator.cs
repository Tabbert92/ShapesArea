﻿using System.Collections.Generic;

namespace ShapeAreaCalculation
{
    public class ShapeAreaCalculator
    {
        public double СalculateArea(string shapeName, List<double> shapeParameters)
        {
            Shape shape;

            if (shapeName == "circle")
                shape = new Circle(shapeParameters);

            else if (shapeName == "triangle")
                shape = new Triangle(shapeParameters);

            else return -1;

            return shape.CalculateArea();
        }
    }
}