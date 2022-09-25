// See https://aka.ms/new-console-template for more information


using Week_01.HelloCS;


int num1 = 0; int num2 = 0;

Console.WriteLine("Console Calculator App in C#\r\n");

Console.WriteLine("------------------------\n");


Console.WriteLine("Choose options from the following list below:");

Console.WriteLine("Press 1 for Addition");
Console.WriteLine("Press 2 for Subtraction");
Console.WriteLine("Press 3 for Multiplication");
Console.WriteLine("Press 4 for Division");
Console.WriteLine("Enter a number:");
var input = Console.ReadLine();


Console.WriteLine("Enter a number and press enter:");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter another number and press enter:");
num2 = Convert.ToInt32(Console.ReadLine());


switch(input)
{
    case "1": 
        Calculator.Addition(num1, num2);
        break;
    case "2": 
        Calculator.Subtraction(num1, num2);
        break;
    case "3": 
        Calculator.Multiplication(num1, num2);
        break;
    case "4": 
        Calculator.Division(num1, num2);
        break;
}

Console.WriteLine("Press any key to exit");
Console.ReadKey();


