using System;
namespace SwitchCase;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number : ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter operator to perform operation : ");
        string symbol = Console.ReadLine();
        Console.Write("Enter second number : ");
        double number2 = double.Parse(Console.ReadLine());

        switch(symbol)
        {
            case "+":
            {
                Console.WriteLine($"{number1} + {number2} = "+(number1+number2));
                break;
            }
             case "-":
            {
                Console.WriteLine($"{number1} - {number2} = "+(number1-number2));
                break;
            }
             case "*":
            {
                Console.WriteLine($"{number1} * {number2} = "+(number1*number2));
                break;
            }
             case "/":
            {
                Console.WriteLine($"{number1} / {number2} = "+(number1/number2));
                break;
            }
             case "%":
            {
                Console.WriteLine($"{number1} % {number2} = "+(number1%number2));
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Input");
                break;
            }
        }
    }
}