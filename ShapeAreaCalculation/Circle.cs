using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapeAreaCalculation
{
    public class Circle : Shape
    {
        public Circle(List<double> parameterList) : base(parameterList, 1){}

        public override double CalculateArea()
        {
            if (!CanExist) return -1;

            return Math.PI * Math.Pow(ParameterList.First(), 2);
        }
    }
}
