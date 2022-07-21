using System.Collections.Generic;

namespace ShapeAreaCalculation
{
    public abstract class Shape
    {
        public int NumberOfParameters { get; }

        public List<double> ParameterList { get; }

        public bool CanExist { get; }

        protected Shape(List<double> parameterList, int numberOfParameters)
        {
            ParameterList = parameterList;
            NumberOfParameters = numberOfParameters;
            CanExist = CanExistCheck();
        }

        protected virtual bool CanExistCheck()
        {
            return BaseParametersCheck();
        }

        protected bool BaseParametersCheck()
        {
            if (ParameterList == null || NumberOfParameters != ParameterList.Count) return false;

            foreach (var parameter in ParameterList)
                if (parameter <= 0) return false;
            
            return true;

        }

        public abstract double CalculateArea();
    }
}