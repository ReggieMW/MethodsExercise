namespace MethodsExercise
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What makes you happy?");
            string happy = Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            double prisonSentence = double.Parse(Console.ReadLine());

            Console.WriteLine("What is your biggest fear?");
            string fear = Console.ReadLine();

            Console.WriteLine($"Bad news {name}, President Musk has declared that {happy} is now illegal. Indulging in this will be sentenced up to {prisonSentence} years in prison, all the while being tormented by {fear}. Please write your local representatives with any concerns.");

            int numOne = 25;
            int numTwo = 5;
            
            int sum = AddTwo(numOne, numTwo);
            int difference = SubtractTwo(numOne, numTwo);
            int product = MultiplyTwo(numOne, numTwo);
            int quotient = DivideTwo(numOne, numTwo);   
            
            Console.WriteLine($"With 25 and 5, the sum is {sum}, the difference is {difference}, the product is {product}, and the quotient is {quotient}.");
        }
        
        
        public static int AddTwo(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int SubtractTwo(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int MultiplyTwo(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int DivideTwo(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }
    }
}