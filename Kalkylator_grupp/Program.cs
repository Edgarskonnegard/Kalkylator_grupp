namespace Kalkylator_grupp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool keepPlaying = true;
            do
            {
                int input;
                int firstInt;
                int secondInt;
                Console.WriteLine("Fractions");
                Console.WriteLine("Enter a option by the number: ");
                Console.WriteLine("Option 1: Addition");
                Console.WriteLine("Option 2: Subtraction");
                Console.WriteLine("Option 3: Multiplication");
                Console.WriteLine("Option 4: Division");
                Console.WriteLine("Option 5: Power");
                while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 5)
                {
                    Console.WriteLine("Invalid input");
                }
                Console.WriteLine("Enter first number: ");
                while (!int.TryParse(Console.ReadLine(), out firstInt))
                {
                    Console.WriteLine("Invalid input");
                }

                Console.WriteLine("Enter second number: ");
                while (!int.TryParse(Console.ReadLine(), out secondInt))
                {
                    Console.WriteLine("Invalid input");
                }

                switch (input)
                {
                    case 1:
                        Console.WriteLine(Addition(firstInt, secondInt));
                        break;
                    case 2:
                        Console.WriteLine(Subtraction(firstInt, secondInt));
                        break;
                    case 3:
                        Console.WriteLine(Multiplikation(firstInt, secondInt));
                        break;
                    case 4:
                        Console.WriteLine(Division(firstInt, secondInt));
                        break;
                    case 5:
                        Console.WriteLine(Power(firstInt, secondInt));
                        break;
                    case 6:
                        keepPlaying = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (keepPlaying);

        }


        public static int Addition(int value1, int value2)
        {
            return value1 + value2;
        }

        private static int Subtraction(int firstInt, int secondInt)
        {

            int sum = firstInt - secondInt;
            return sum;
        }
        private static int Multiplikation(int firstInt, int secondInt)
        {
            int sum = firstInt * secondInt;
            return sum;
        }

        private static double Division(double a, double b)
        {
            try
            {
                double fraction = a / b;
                return fraction;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Invalid input. Division by zero is not authorized! Zero is returned");
                return 0;
            }
        }

        private static double Power(double a, double exponent)
        {
            return Math.Pow(a, exponent);
        }




    }
}
