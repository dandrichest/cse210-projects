using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int favoriteNumber = AddNumbers();
        int square = SquareNumber(favoriteNumber);

        DisplayResult(userName, square);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string user = Console.ReadLine();
        return user;
    }

    static int AddNumbers()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int favoriteNumber = int.Parse(number);
        return favoriteNumber;
    }

    static int SquareNumber(int favoriteNumber)
    {
        int square = (int)Math.Pow(favoriteNumber, 2);
        return square;
    }

    static void DisplayResult(string user, int square)
    {
        Console.WriteLine($"{user}, the square of your number is {square}");
    }
}
