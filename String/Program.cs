using System;
namespace String;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a word : ");
        string word=Console.ReadLine();
        string tempWord=word;
        Console.Write("Enter a short string to find occurence in the above string : ");
        string subWord=Console.ReadLine();
        int occurence=0;

        for(int i=0,j=0;i<word.Length;i++)
        {
            if(tempWord.StartsWith(subWord[0]))
            {
                if(tempWord.Contains(subWord))
                {
                    occurence++;
                }
            }
            tempWord=tempWord.Remove(j,1);
        }
        Console.WriteLine(occurence);
    }
}