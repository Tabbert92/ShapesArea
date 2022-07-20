namespace ShapeAreaCalculation
{
    public class Triangle : Shape
    {
        public bool IsRight { get; }

        public Triangle(List<double> parameterList) : base(parameterList, 3)
        {
            IsRight = IsRightCheck();
        }
        protected override bool CanExistCheck()
        {
            if (!BaseParametersCheck()) return false;

            ParameterList.Sort();

            if (ParameterList[0] + ParameterList[1] <= ParameterList[2]) return false;

            return true;
        }

        private bool IsRightCheck()
        {
            if (!canExist) return false;

            if (Math.Abs(Math.Pow(ParameterList[0], 2) + Math.Pow(ParameterList[1], 2) - Math.Pow(ParameterList[2], 2)) < 0.00001) return true;

            return false;
        }
        public override double CalculateArea()
        {
            if (!canExist) return -1;

            if (IsRight)
            {
                return ParameterList[0] * ParameterList[1] / 2;
            }

            var halfPer = (ParameterList[0] + ParameterList[1] + ParameterList[2]) / 2;
            return Math.Sqrt(halfPer * (halfPer - ParameterList[0]) * (halfPer - ParameterList[1]) * (halfPer - ParameterList[2]));
        }
    }
}
