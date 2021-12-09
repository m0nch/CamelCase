using System;

class Result
{
    public static int Camelcase(string s)
    {
        int wordCount = 1;
        char[] charArray = s.ToCharArray();
        foreach (var item in charArray)
        {
            if (char.IsUpper(item))
            {
                wordCount++;
            }
        }
        return wordCount;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        int result = Result.Camelcase(s);

        Console.WriteLine(result);
        Console.ReadKey();
    }
}

