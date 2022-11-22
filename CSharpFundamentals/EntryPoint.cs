﻿using System;

class EntryPoint
{
    public static void Main()
    {
        // Refactoring

        // Arrays a = new();
        // a.LearnArrays();

        // Loop l = new();
        // l.LearnLoops();

        // Conditional c = new();
        // c.LearnConditionals();

        Methods m = new();
        m.Print();
        m.PrintSomething("I am yet another method");
        var s = m.Add(45.67, 67.89, 12.4);
        var s1 = m.Add(45.67, 67.89);
        var p1 = m.Multiply(5, 6, 7, 8);
        var p2 = m.Multiply(5, 6, 7, 8, 10, 45, 23, 45);

        Console.WriteLine($"Sum1={s} Sum2={s1} Product1={p1} Product2={p2}");

        byte[] numbers = { 34, 56, 12, 33, 89, 65, 21, 90 };
        var (minimum, maximum) = m.GetMinMax(numbers);
        

    }
}
