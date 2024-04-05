using System;
namespace WhileLoop;
class Program 
{
    public static void Main(string[] args)
    {
        // 1
        int number = 0;
        while (number<=25)
        {
            if(number%2==0)
            {
                Console.WriteLine(number);
            }
            number++;
        }
        Console.WriteLine();

        // 2
        int validNumber;
        bool isValid;
        while(true){
            Console.Write("Enter a Valid number : ");
            isValid = int.TryParse(Console.ReadLine(),out validNumber);
            if(isValid)
            {
                Console.WriteLine("You Entered a Valid Number");
                break;
            }
            Console.WriteLine("Invalid number");
        }
    }
}