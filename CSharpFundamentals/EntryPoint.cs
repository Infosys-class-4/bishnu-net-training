using System;

// // Top-level statements - implicit Main() entrypoint

// // Conditionals - branching
// Console.Write("Enter any number: ");
// var numberText = Console.ReadLine();
// var number = short.Parse(numberText);
// //var number = Convert.ToInt16(numberText);

// if (number % 2 == 0)
// {
//     // Even
//     Console.WriteLine(number + " is even");
// }
// else
// {
//     // Odd
//     Console.WriteLine(number + " is odd");
// }

// // Classwork: Ask user to enter his name and convert that to uppercase and 
// // print on console.

// int mark = 45;

// // If marks is less than 40, print "You failed"
// // If marks is less than 60 and greater than 40, print "You Passed with second division"
// // If marks is less than 80 and greater than 60, print "You Passed with first division"
// // If marks is greater than 80, print "You Passed with distiction"

// if (mark < 40)
// {
//     Console.WriteLine("You failed");
// }
// else if (mark < 60)
// {
//     Console.WriteLine("You Passed with second division");
// }
// else if (mark < 80)
// {
//     Console.WriteLine("You Passed with first division");
// }
// else
// {
//     Console.WriteLine("You Passed with distiction");
// }

// // Print corresponding roman equivalents for numbers upto 5
// // 1 => I
// // 2 => II
// // 3 => III
// // 4 => IV
// // 5 => V

// var z = Console.ReadLine();
// var n = int.Parse(z);
// var result = "";

// if (n is 1)
// {
//     result = "I";
// }
// else if (n is 2)
// {
//     result = "II";
// }
// else if (n is 3)
// {
//     result = "III";
// }
// else if (n is 4)
// {
//     result = "IV";
// }
// else if (n is 5)
// {
//     result = "V";
// }

// Console.WriteLine(result);

// // Switch
// switch (n)
// {
//     case 1:
//         result = "I";
//         break;
//     case 2:
//         result = "II";
//         break;
//     case 3:
//         result = "III";
//         break;
//     case 4:
//         result = "IV";
//         break;
//     case 5:
//         result = "V";
//         break;
// }

// Console.WriteLine(result);


// //Question 4
// Console.Write("Enter a number: ");
// var num = Convert.ToInt16(Console.ReadLine());

// if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0)
// {
//     Console.WriteLine("Not divisible by 2, 3 and 5");
// }
// else
// {
//     if (num % 2 == 0)
//     {
//         Console.WriteLine("It's even number");
//     }

//     if (num % 3 == 0)
//     {
//         Console.WriteLine("It's multiple of 3 ");
//         if (num % 5 == 0)
//         {
//             Console.WriteLine("It's multiple of 5");
//         }
//     }
// }


// // Loops or iteration statements: for, foreach, while, do while

// for (int counter = 10; counter < 200; counter++)
// {
//     Console.Write(100 + " ");
// }

// Print numbers from 1-100 in console

// for (int counter = 1; counter <= 100; counter = counter + 1)
// {
//     Console.Write(counter + " ");
// }

// int counterx = 1;
// while (counterx <= 100)
// {
//     Console.Write(counterx + " ");

//     counterx = counterx + 1;
// }

// Print "Hello" until user press "y" in the console
// While and Do-while can only implement this, we can't use for loop for this solution
// char yes = 'y';
// while (yes == 'y')
// {
//     Console.WriteLine("Hello");
//     Console.Write("Print another hello?:");
//     var keyPressed = Console.ReadKey();    
//     yes = keyPressed.KeyChar;
// }


// // Print all even numbers upto 100
// for (int counter = 2; counter <= 100; counter = counter + 2)
// {
//     Console.Write(counter + " ");
// }

// for (int counter = 1; counter <= 100; counter++)
// {
//     if (counter % 2 == 0)
//     {
//         Console.Write(counter + " ");
//     }
// }

// 3X3
// 1 2 3
// 4 5 6
// 7 8 9

//
// #
// ##
// ###
// ####
int val = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        val++;
        Console.Write(val + "\t");   // Escape sequences 
    }

    Console.WriteLine();
}

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

//Print multiplication table for 8
// 8 * 1 = 8
// 8 * 2 = 16
// 8 * 3 = 24
// ....
// 8 * 10 = 80

for (int i = 1; i <= 10; i++)
{
    int product = 8 * i;
    Console.WriteLine($"8 * {i} = {product}");
}
