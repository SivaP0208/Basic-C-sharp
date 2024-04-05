using System;
namespace DateTimes;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date = new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(date.Year);
        Console.WriteLine(date.Month);
        Console.WriteLine(date.Day);
        Console.WriteLine(date.Hour);
        Console.WriteLine(date.Minute);
        Console.WriteLine(date.Second);

        Console.WriteLine("Enter a date : yyyy/MM/dd hh:mm:ss tt ");
        bool isCorrect1 = DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out DateTime exactDate);
        while(!isCorrect1)
        {
            Console.WriteLine("Invalid Date please renter again in proper format");
            isCorrect1=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out exactDate);
        }
        string date1 = exactDate.ToString("yyyy/MM/dd hh:mm:ss tt");
        char[] unwanted = {'/',':',' '};
        string[] splittedDate = date1.Split(unwanted);
        for(int i=splittedDate.Length-1;i>=0;i--)
        {
            Console.Write(splittedDate[i]+" ");
        }
        Console.WriteLine();
        Console.WriteLine("Enter a date : yyyy/MM/dd hh:mm:ss tt ");
        bool isCorrect2 = DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out DateTime correctDate);
        while(!isCorrect2)
        {
            Console.WriteLine("Invalid Date please renter again in proper format");
            isCorrect2=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out correctDate);
        }
        Console.WriteLine($"{correctDate.Year} / {correctDate.Month} / {correctDate.Day}");
    }
}