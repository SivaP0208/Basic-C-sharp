using System;
namespace Methods;
class Program
{
    public static void Main(string[] args)
    {
        bool exit=true;
        do
        {
            Console.WriteLine("Select an option to Perform Operation");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Divison");
            int userInput = int.Parse(Console.ReadLine());
            
            Console.Write("Enter first number : ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number : ");
            int number2 = int.Parse(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                {
                    Console.WriteLine($"Addition of {number1} and {number2} is {Addition(number1,number2)}");
                    break;
                }
                case 2:
                {
                    Console.WriteLine($"Subtraction of {number1} and {number2} is {Subtraction(number1,number2)}");
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"Multiplication of {number1} and {number2} is {Multiplication(number1,number2)}");
                    break;
                }
                case 4:
                {
                    Console.WriteLine($"Divison of {number1} and {number2} is {Divison(number1,number2)}");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Input");
                    break;
                }
            }
            bool isCorrect=true;
            while(isCorrect)
            {
                Console.WriteLine("Do you want to repeat the process again? yes or no");
                string wish=Console.ReadLine();
                if(wish =="yes")
                {
                    exit=true;
                    break;
                }
                else if(wish == "no")
                {
                    exit=false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input Please provide Valid Input");
                }
            }
        } while (exit);
        Console.WriteLine("Thank You");

        static int Addition(int number1,int number2)
        {
            return number1+number2;
        }
        static int Subtraction(int number1,int number2)
        {
            return number1-number2;
        }
        static int Multiplication(int number1,int number2)
        {
            return number1*number2;
        }
        static int Divison(int number1,int number2)
        {
            return number1/number2;
        }
    }
}