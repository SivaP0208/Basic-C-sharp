using System;
namespace DoWhileLoop;
class Program 
{
    public static void Main(string[] args)
    {
        bool isWish=false;
        string wish;
        do
        {
            Console.Write("Enter a number to find Odd or Even : ");
            int number=int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine($"{number} is Even Number");
            }else
            {
                Console.WriteLine($"{number} is Odd Number");
            }
            bool isValid=true;
            while(isValid)
            {
                Console.Write("Do you Want to repeat the Process again? yes or no : ");
                wish = Console.ReadLine();
                if(wish=="yes")
                {
                isWish=true;
                isValid=false;
                }
                else if (wish=="no")
                {
                isWish=false;
                isValid=false;
                }
                else
                {
                Console.WriteLine("Invalid Input Please provide a Valid Input");
                }
            }
        } while (isWish);


    }
}