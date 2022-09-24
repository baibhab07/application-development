namespace Week_01.HelloCS
{
    public class HelloWorld
    {
        public void ReadInput()
        {
            Console.WriteLine("Insert a first number:");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert a second number:");
            var num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operator of your choice:");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Addition(num1, num2);
            }
            else if (op == "-") 
            {
                Subtraction(num1, num2);
            } else if (op == "*")
            {
                Multiplication(num1, num2);
            } else if (op == "/")
            { 
                Division(num1, num2);
            } else
            {
                Console.WriteLine("Invalid Operator");

            }
        }
        public void Addition(int num1, int num2)
        {
            Console.WriteLine("Addition");
            int sum = num1 + num2;
            Console.WriteLine("The sum is " + sum);
        }

        public void Subtraction(int num1, int num2)
        {
            Console.WriteLine("Subtraction");
            int difference = num1 - num2;
            Console.WriteLine("The difference is " + difference);

        }

        public void Multiplication(int num1, int num2)
        {
            Console.WriteLine("Multiplication");
            int product = num1 * num2;
            Console.WriteLine("The product is " + product);

        }
        public void Division(int num1, int num2)
        {
            Console.WriteLine("Division");
            double division = num1 / num2;
            Console.WriteLine("The result is " + division);

        }
        public void StringConcat()
        {
            Console.WriteLine("String Conactenation");
            Console.WriteLine("Insert a word:");
            var string1 = Console.ReadLine();
            Console.WriteLine("Insert another word:");
            var string2 = Console.ReadLine();
            var string3 = string1 + string2;
            Console.WriteLine("The result is " + string3);

        }
        public void StringInterpolation()
        {
            Console.WriteLine("String Interpolation");
            Console.WriteLine("Insert a word:");
            var string1 = Console.ReadLine();
            Console.WriteLine("Insert another word:");
            var string2 = Console.ReadLine();
            Console.WriteLine($"{string1} { string2}");
        }
    }
}
