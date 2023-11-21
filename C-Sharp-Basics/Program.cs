namespace C_Sharp_Basics
{
    internal class Program
    {
        public static float[] TryCreateArray(string errorMessage)
        {
            string? numberString;
            int number;
            float[] array = Array.Empty<float>();
            while (true)
            {
                numberString = Console.ReadLine();

                if (int.TryParse(numberString, out int result))
                {
                    number = result;

                    if (number < 0)
                    {
                        Console.Write(errorMessage);
                        continue;
                    }

                    try
                    {
                        array = new float[number];
                        break;
                    }
                    catch
                    {
                        Console.Write(errorMessage);
                    }
                    break;
                }
                else
                {
                    Console.Write(errorMessage);
                }
            }
            return array;
        }

        public static float TryReadFloat(string errorMessage)
        {
            string? numberString;
            float number;
            while (true)
            {
                numberString = Console.ReadLine();

                if (float.TryParse(numberString, out float result))
                {
                    number = result;
                    break;
                }
                else
                {
                    Console.Write(errorMessage);
                }
            }
            return number;
        }


        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            float[] array = TryCreateArray("Enter valid array size: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}] = ");
                float number = TryReadFloat($"Not valid number!\narray[{i}] = ");
                array[i] = number;
            }

            Console.Write("array = {");
            foreach (float element in array)
            {
                Console.Write($" {element}");
            }
            Console.WriteLine(" }");

            Console.WriteLine("Press any key to close this window . . .");
            Console.ReadKey();
        }
    }
}