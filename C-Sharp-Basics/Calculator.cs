namespace C_Sharp_Basics
{
    internal class Calculator
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
            if (secondNumber != 0)
            {
                decimal quotient = firstNumber / secondNumber;
                return quotient;
            }
            else
            {
                throw new ArgumentException("can't divide by zero");
            }
        }

        public static decimal Multiply(decimal firstNumber, decimal secondNumber)
        {
            decimal product = firstNumber * secondNumber;
            return product;
        }
    }
}

