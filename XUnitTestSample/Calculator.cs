using System.Numerics;

namespace XUnitTestSample
{
    public static class Calculator<T> where T : INumber<T>
    {
        public static T Sum(T number1, T number2)
        {
            return number1 + number2;
        }

        public static T Subtract(T number1, T number2)
        {
            return number1 - number2;
        }

        public static T Multiply(T number1, T number2)
        {
            return number1 * number2;
        }

        public static T Divide(T number1, T number2)
        {
            return number1 / number2;
        }
    }
}