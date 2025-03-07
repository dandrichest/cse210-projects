using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = [];
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            if (input == "0")
            {
                break;
            }
            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
            }

        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
            return;
        }
        int sum = numbers.Sum();
        double average = numbers.Average();
        int highest = numbers.Max();



        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average:f2}");
        Console.WriteLine($"Highest number: {highest}");

    }
}