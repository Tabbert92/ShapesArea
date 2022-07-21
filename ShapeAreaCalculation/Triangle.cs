using System;
using System.Collections.Generic;

namespace ShapeAreaCalculation
{
    public class Triangle : Shape
    {
        public bool IsRight { get; }

        public Triangle(List<double> parameterList) : base(parameterList, 3)
        {
            IsRight = IsRightAngledCheck();
        }

        protected override bool CanExistCheck()
        {
            if (!BaseParametersCheck()) return false;

            ParameterList.Sort();
            if (ParameterList[0] + ParameterList[1] <= ParameterList[2]) return false;

            return true;
        }

        private bool IsRightAngledCheck()
        {
            if (!CanExist) return false;

            if (Math.Abs(Math.Pow(ParameterList[0], 2) + Math.Pow(ParameterList[1], 2) - Math.Pow(ParameterList[2], 2)) < Double.Epsilon) return true;

            return false;
        }
        public override double CalculateArea()
        {
            if (!CanExist) return -1;

            if (IsRight)
                return ParameterList[0] * ParameterList[1] / 2;
            
            var halfPerimeter = (ParameterList[0] + ParameterList[1] + ParameterList[2]) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - ParameterList[0]) * (halfPerimeter - ParameterList[1]) * (halfPerimeter - ParameterList[2]));
        }
    }
}
