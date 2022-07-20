namespace ShapeAreaCalculation
{
    public abstract class Shape
    {
        public int NumberOfParameters { get; }
        public List<double> ParameterList { get; }
        public bool canExist { get; }

        public Shape(List<double> parameterList, int numberOfParameters)
        {
            ParameterList = parameterList;
            NumberOfParameters = numberOfParameters;
            canExist = CanExistCheck();
        }


        protected virtual bool CanExistCheck()
        {
            return BaseParametersCheck();
        }
        protected bool BaseParametersCheck()
        {
            if (ParameterList == null || NumberOfParameters != ParameterList.Count) return false;

            foreach (var parameter in ParameterList)
            {
                if (parameter <= 0) return false;
            }
            return true;
        }
        public abstract double CalculateArea();
    }

}