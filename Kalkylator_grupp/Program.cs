namespace Kalkylator_grupp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool keepPlaying = true;
            do
            {
                Console.WriteLine("Enter a option by the number: ");
                Console.WriteLine("Option 1: Addition");
                Console.WriteLine("Option 2: Subtraction");
                Console.WriteLine("Option 3: Multiplication");
                Console.WriteLine("Option 4: Division");
                Console.WriteLine("Option 5: Power");
                Console.WriteLine("Option 6: Exit");
                
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine(Addition(GetFirstNum(), GetSecNum()));
                        break;
                    case 2:
                        Console.WriteLine(Subtraction(GetFirstNum(), GetSecNum()));
                        break;
                    case 3:
                        Console.WriteLine(Multiplikation(GetFirstNum(), GetSecNum()));
                        break;
                    case 4:
                        Console.WriteLine(Division(GetFirstNum(), GetSecNum()));
                        break;
                    case 5:
                        Console.WriteLine(Power(GetFirstNum(), GetSecNum()));
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

        private static int GetFirstNum()
        {
            Console.WriteLine("Enter first number: ");
            return Convert.ToInt32(Console.ReadLine());
            
        }
        private static int GetSecNum()
        {
            Console.WriteLine("Enter second number: ");
            return Convert.ToInt32(Console.ReadLine());
            
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
