// LINQ - Language INtegrated Query
// Powerful feature to query collections
// Collections: Arrays, Lists, Stack, Queue, Dictionary

using System;
using System.Collections.Generic;
using System.Linq;
using LivingThings;

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


        // Sqaures of numbers > 70

        // Method syntax
        var squaresGreater70 = numbers.Where(x => x > 70).Select(z => z * z);

        // Expression syntax
        squaresGreater70 = from x in numbers
                           where x > 70
                           select x * x;

        //Square root of all numbers which are multiple of 3

        // MS
        var srofnm3 = numbers.Where(x => x % 3 == 0).Select(y => Math.Sqrt(y));

        //ES
        srofnm3 = from x in numbers
                  where x % 3 == 0
                  select Math.Sqrt(x);

        // Check if ANY of the number is multiple of 7 on "numbers"
        var multipleOf7 = numbers.Any(x => x % 7 == 0);

        // Check if ALL the numbers in "numbers" are multiple of 7
        var allMultipleOf7 = numbers.All(x => x % 7 == 0);

        // Get first 5 items in numbers
        var first5 = numbers.Take(5);

        // Skip first 2 and get next 5
        var skip2AndGetNext5 = numbers.Skip(2).Take(5);

        Person p1 = new Person();
        p1.age = 23;

        Person p2 = new Person();
        p2.age = 32;

        Person p3 = new Person();
        p3.age = 33;

        Person p4 = new Person();
        p4.age = 20;

        Person p5 = new Person();
        p5.age = 26;

        Person p6 = new Person();
        p6.age = 12;

        Person[] people = { p1, p2, p3, p4, p5, p6 };

        // Get all people who are adult now
        var adults = people.Where(x => x.age > 18);
        
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

