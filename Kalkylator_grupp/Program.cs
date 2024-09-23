namespace Kalkylator_grupp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fractions");
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


    }
}
