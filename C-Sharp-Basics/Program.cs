namespace C_Sharp_Basics
{
    internal class Program
    {
        public static decimal TryReadNumber()
        {
            string? numberString;
            decimal number;
            while (true)
            {

                numberString = Console.ReadLine();

                if (decimal.TryParse(numberString, out decimal result))
                {
                    number = result;
                    break;
                }
                else
                {
                    Console.Write("Enter correct number: ");
                }
            }
            return number;
        }


        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            decimal firstNumber = TryReadNumber();

            Console.Write("Enter second number: ");
            decimal secondNumber = TryReadNumber();

            Console.WriteLine($"Sum: {Calculator.Add(firstNumber, secondNumber)}");
            Console.WriteLine($"Difference: {Calculator.Subtract(firstNumber, secondNumber)}");
            Console.WriteLine($"Product: {Calculator.Multiply(firstNumber, secondNumber)}");
            if (secondNumber != 0)
            {
                Console.WriteLine($"Quotient: {Calculator.Divide(firstNumber, secondNumber)}");
            }
            else
            {
                Console.WriteLine("Can't divide by zero");
            }

        }
    }
}