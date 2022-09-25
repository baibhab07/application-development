namespace Week_01.HelloCS
{
    public class Calculator
    {
        
        public static void Addition(int num1, int num2)
        {
            Console.WriteLine("Addition");
            int sum = num1 + num2;
            Console.WriteLine("The sum is " + sum);
        }

        public static void Subtraction(int num1, int num2)
        {
            Console.WriteLine("Subtraction");
            int difference = num1 - num2;
            Console.WriteLine("The difference is " + difference);

        }

        public static void Multiplication(int num1, int num2)
        {
            Console.WriteLine("Multiplication");
            int product = num1 * num2;
            Console.WriteLine("The product is " + product);

        }
        public static void Division(int num1, int num2)
        {
            Console.WriteLine("Division");
            double division = num1 / num2;
            Console.WriteLine("The result is " + division);

        }
    }
}
