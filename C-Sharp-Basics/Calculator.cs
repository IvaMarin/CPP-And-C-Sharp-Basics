namespace C_Sharp_Basics
{
    internal static class Calculator
    {
        public static decimal Add(decimal firstNumber, decimal secondNumber)
        {
            decimal sum = firstNumber + secondNumber;
            return sum;
        }

        public static decimal Subtract(decimal firstNumber, decimal secondNumber)
        {
            decimal difference = firstNumber - secondNumber;
            return difference;
        }

        public static decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            decimal quotient = firstNumber / secondNumber;
            return quotient;
        }

        public static decimal Multiply(decimal firstNumber, decimal secondNumber)
        {
            decimal product = firstNumber * secondNumber;
            return product;
        }
    }
}

