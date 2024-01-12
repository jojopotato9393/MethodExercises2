namespace MethodsExercises2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var result = Divide(9, 3);
            var result2 = Multiply(9, 3);

            Console.WriteLine("to divide enter two numbers");
            int answer = Convert.ToInt32(Console.ReadLine()); // i feel like there is a lot more simple way to do this but yea
            int answer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"you want divide {answer} by {answer1}");
            Console.WriteLine();
            int solution = Divide(answer, answer1);
            Console.WriteLine($"your answer is {solution}");

            Console.WriteLine();

            Console.WriteLine("to multiply enter two numbers");
            int calculation = Convert.ToInt32(Console.ReadLine());
            int calculation1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"you want to multiply {calculation} by {calculation1}");
            Console.WriteLine();
            int solution1 = Multiply(calculation, calculation1);
            Console.WriteLine($"you answer is {solution1}");



        }
        public static int Divide(int x, int y)
        {

            return x / y;
        }
        public static int Multiply(int x, int y)
        {
            return (x * y);
        }


    
    }
}
