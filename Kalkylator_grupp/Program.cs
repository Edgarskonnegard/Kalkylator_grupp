namespace Kalkylator_grupp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fractions");

            string? input = Console.ReadLine();

            int firstInt;
            int secondInt;
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
                case "Add":
                    Addition(firstInt, secondInt);
                    break;
                case "Sub":
                    Subtraction(firstInt, secondInt);
                    break;
                case "Multipli":
                    Multiplikation(firstInt, secondInt);
                    Console.WriteLine("Division");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

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
