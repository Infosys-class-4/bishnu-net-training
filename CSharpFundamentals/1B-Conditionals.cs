using System;

class Conditional
{
    public void LearnConditionals()
    {
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

        int mark = 45;

        // If marks is less than 40, print "You failed"
        // If marks is less than 60 and greater than 40, print "You Passed with second division"
        // If marks is less than 80 and greater than 60, print "You Passed with first division"
        // If marks is greater than 80, print "You Passed with distiction"

        if (mark < 40)
        {
            Console.WriteLine("You failed");
        }
        else if (mark < 60)
        {
            Console.WriteLine("You Passed with second division");
        }
        else if (mark < 80)
        {
            Console.WriteLine("You Passed with first division");
        }
        else
        {
            Console.WriteLine("You Passed with distiction");
        }

        // Print corresponding roman equivalents for numbers upto 5
        // 1 => I
        // 2 => II
        // 3 => III
        // 4 => IV
        // 5 => V

        var z = Console.ReadLine();
        var n = int.Parse(z);
        var result = "";

        if (n is 1)
        {
            result = "I";
        }
        else if (n is 2)
        {
            result = "II";
        }
        else if (n is 3)
        {
            result = "III";
        }
        else if (n is 4)
        {
            result = "IV";
        }
        else if (n is 5)
        {
            result = "V";
        }

        Console.WriteLine(result);

        // Switch
        switch (n)
        {
            case 1:
                result = "I";
                break;
            case 2:
                result = "II";
                break;
            case 3:
                result = "III";
                break;
            case 4:
                result = "IV";
                break;
            case 5:
                result = "V";
                break;
        }

        Console.WriteLine(result);


        //Question 4
        Console.Write("Enter a number: ");
        var num = Convert.ToInt16(Console.ReadLine());

        if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0)
        {
            Console.WriteLine("Not divisible by 2, 3 and 5");
        }
        else
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("It's even number");
            }

            if (num % 3 == 0)
            {
                Console.WriteLine("It's multiple of 3 ");
                if (num % 5 == 0)
                {
                    Console.WriteLine("It's multiple of 5");
                }
            }
        }

    }
}