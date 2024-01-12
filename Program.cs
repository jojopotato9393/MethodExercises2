namespace MethodsExercises2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var result = divide(9, 3);
            var result2 = multiply(9, 3);

            Console.WriteLine("to divide enter two numbers");
            int answer = Convert.ToInt32(Console.ReadLine()); // i feel like there is a lot more simple way to do this but yea
            int answer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($" you wana divide {answer} by {answer1}");
            Console.WriteLine();
            Console.WriteLine(divide(answer, answer1));
            Console.WriteLine("is your answer");

            Console.WriteLine();

            Console.WriteLine("to multiply enter two numbers");
            int calculation = Convert.ToInt32(Console.ReadLine());
            int calculation1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($" you want to multiply {calculation} by {calculation1}");
            Console.WriteLine();
            Console.WriteLine(multiply(calculation, calculation1));
            Console.WriteLine("is your answer");



        }
        public static int divide(int x, int y)
        {

            return x / y;
        }
        public static int multiply(int x, int y)
        {
            return (x * y);
        }


    
    }
}
