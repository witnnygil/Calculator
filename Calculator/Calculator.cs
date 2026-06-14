namespace Calculator
{
    internal static class Calculator
    {
        public static double Divide(double fistNumber, double secondNumber)
        {
            double result;
            result = fistNumber / secondNumber;
            return result;
        }

        public static double Subtract(double fistNumber, double secondNumber)
        {
            double result;
            result = fistNumber - secondNumber;
            return result;
        }

        public static double Multiply(double fistNumber, double secondNumber)
        {
            double result;
            result = fistNumber * secondNumber;
            return result;
        }

        public static double CalculatePercentage(double fistNumber, double secondNumber)
        {
            double result;
            result = fistNumber * (secondNumber / 100);
            return result;
        }

        public static double Add(double fistNumber, double secondNumber)
        {
            double result;
            result = fistNumber + secondNumber;
            return result;
        }
    }
}
