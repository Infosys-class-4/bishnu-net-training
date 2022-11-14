using System;

// Top-level statements - implicit Main() entrypoint

// Conditionals - branching
Console.Write("Enter any number: ");
var numberText = Console.ReadLine();
var number = short.Parse(numberText);
//var number = Convert.ToInt16(numberText);

if (number % 2 == 0)
{
    // Even
    Console.WriteLine(number + " is even");
}
else
{
    // Odd
    Console.WriteLine(number + " is odd");
}

// Classwork: Ask user to enter his name and convert that to uppercase and 
// print on console.


// Creating objects
// Initializing fields
// Person person1 = new();
// person1.name = "Sitaram";
// person1.age = 12;

// string message = person1.GetLegalGreeting();
// Console.WriteLine(message);


