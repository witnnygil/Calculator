using Microsoft.VisualBasic.Logging;

namespace Calculator
{
    internal static class Calculator
    {
        // Estos son  los métodos que se ejecutan al dar doble click en el boton, dentro de ellos agregamos las acciones que queremos realizar con ellos.
        // El método definido, recibe como parametros 1number y 2number, de tipo double. Y retorna el resultado de la operación matematica que realiza.
        // se declara la variable de tipo double como "result", luego se llama y se le asigna la operación a realizar
        // return, esto lo que hace es que devuelve el resultado a quién llamó el método
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

        // Aquí se usa Math.Pow, porque el simbolo ^ por sí solo no es válido para esta operación,
        // por lo que el lenguaje tiene su propio método para realizar certas operaciones matemáticas
        public static double Pow(double fistNumber, double secondNumber)
        {
            double result;
            result = Math.Pow(fistNumber, secondNumber);
            return result;
        }
    }
}
