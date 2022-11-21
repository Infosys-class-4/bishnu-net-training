using System;

class Arrays
{
    public void LearnArrays()
    {
        // Let's talk about arrays

        // One-dimensional array
        byte age1 = 23;  
        byte age2 = 49;

        // 1000
        byte[] ages = new byte[1000];
        ages[0] = 34;
        ages[1] = 34;
        ages[2] = 34;
        ages[3] = 34;
        //....
        ages[999] = 90;

        var a = ages[49];

        // multi-dimensional
        int[,] table = new int[2, 3];

        table[0, 0] = 1;
        table[0, 1] = 2;
        table[0, 2] = 3;
        table[1, 0] = 4;
        table[1, 1] = 5;
        table[1, 2] = 6;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(table[i, j] + "\t");   // Escape sequences 
            }

            Console.WriteLine();
        }

        string[] names = { "Bishnu", "Sanygel", "Ram" };


        // CW: Decalre a number array with at least 10 items, print squares of each in console.
        short[] numbers = { 78, 3, 4, 5, 6, 6, 7, 812, 3, 45 };

        Console.WriteLine("Using for:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] * numbers[i] + " ");
        }

        Console.WriteLine("\nUsing foreach:");
        foreach (var num in numbers)
        {
            int sqaure = num * num;
            // string interpolation
            Console.WriteLine($"{num} * {num} = {sqaure}");
        }
    }
}