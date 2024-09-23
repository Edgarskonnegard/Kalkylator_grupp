namespace Kalkylator_grupp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fractions");
        }


        static double Divide(double a, double b)
        {
            try
            {
                double fraction = a / b;
                return fraction;
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Invalid input. Division by zero is not authorized");
            }
        }
    }
}
