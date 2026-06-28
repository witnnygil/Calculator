using Microsoft.VisualBasic.Logging;

namespace Calculator
{
    // Clase estática que contiene todas las operaciones matemáticas de la calculadora.
    // Es "static" porque no necesitamos crear un objeto Calculator para usarla;
    // simplemente llamamos a Calculator.Sumar(), Calculator.Multiplicar(), etc.
    // Cada método recibe dos números (double) y devuelve el resultado de la operación.
    internal static class Calculator
    {
        // Divide el primer número entre el segundo y devuelve el resultado.
        // Ejemplo: Divide(10, 2) → devuelve 5
        public static double Divide(double fistNumber, double secondNumber)
        {
            double result;
            result = fistNumber / secondNumber;
            return result;
        }

        // Resta el segundo número del primero y devuelve el resultado.
        // Ejemplo: Subtract(10, 3) → devuelve 7
        public static double Subtract(double fistNumber, double secondNumber)
        {
            double result;
            result = fistNumber - secondNumber;
            return result;
        }

        // Multiplica ambos números y devuelve el resultado.
        // Ejemplo: Multiply(4, 5) → devuelve 20
        public static double Multiply(double fistNumber, double secondNumber)
        {
            double result;
            result = fistNumber * secondNumber;
            return result;
        }

        // Calcula el porcentaje: primer número * (segundo número / 100).
        // Ejemplo: CalculatePercentage(200, 15) → devuelve 30 (el 15% de 200)
        public static double CalculatePercentage(double fistNumber, double secondNumber)
        {
            double result;
            result = fistNumber * (secondNumber / 100);
            return result;
        }

        // Suma ambos números y devuelve el resultado.
        // Ejemplo: Add(5, 3) → devuelve 8
        public static double Add(double fistNumber, double secondNumber)
        {
            double result;
            result = fistNumber + secondNumber;
            return result;
        }

        // Eleva el primer número a la potencia del segundo número.
        // Usamos Math.Pow() porque el operador ^ en C# no sirve para potencias
        // (^ se usa para otra cosa: operaciones a nivel de bits).
        // Ejemplo: Pow(2, 3) → devuelve 8 (2 elevado a la 3)
        public static double Pow(double fistNumber, double secondNumber)
        {
            double result;
            result = Math.Pow(fistNumber, secondNumber);
            return result;
        }
    }
}
