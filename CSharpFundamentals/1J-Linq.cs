// LINQ - Language INtegrated Query
// Powerful feature to query collections
// Collections: Arrays, Lists, Stack, Queue, Dictionary

using System;
using System.Collections.Generic;
using System.Linq;

class LINQ
{
    void Test()
    {
        byte[] numbers = { 23, 45, 11, 22, 33, 12, 90, 98, 87, 65, 55 };

        // Filtering
        // Get all even numbers
        var evenNumbersWithLinq = numbers.Where(number => number % 2 == 0);

        // CW: Get all odd numbers
        // CW: Get all numbers less than 50
        // CW: Get all odd numbers which are less than 50        
        var oddNumbersLessThan50 = numbers.Where(x => x < 50 && x % 2 == 1);
        PrintOutput(oddNumbersLessThan50, "oddNumbersLessThan50");

        string[] names = { "Arun", "Barun", "Chet", "Anil", "Bishwo" };
        
        //Get all names which starts with letter B
        var namesStartingB = names.Where(x => x.StartsWith("B"));
        PrintOutput(namesStartingB, "namesStartingB");

        // Projections
        // Get squares of each element in "numbers" array
        var squares = numbers.Select(x => x * x);
        PrintOutput(squares, "squares");
        
    }

    void PrintOutput<T>(IEnumerable<T> items, string displayText)
    {
        Console.WriteLine($"Printing {displayText}");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

