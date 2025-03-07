using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        if (grade >= 90)
        {
            string letter = "A";
            Console.WriteLine($"Your grade letter is {letter}. Congratulation you passed,");

        }
        else if (grade >= 80)
        {
            string letter = "B";
            Console.WriteLine($"Your grade letter is {letter}. Congratulation you passed,");
        }
        else if (grade >= 70)
        {
            string letter = "C";
            Console.WriteLine($"Your grade letter is {letter}. Congratulation you passed,");
        }
        else if (grade >= 60)
        {
            string letter = "D";
            Console.WriteLine($"Your grade letter is {letter}. You can give it another try,");
        }
        else
        {
            string letter = "F";
            Console.WriteLine($"Your grade letter is {letter}. You can give it another try,");
        }


    }
}