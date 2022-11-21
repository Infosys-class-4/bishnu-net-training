using System;

class Loop
{
    public void LearnLoops()
    {
        // Loops or iteration statements: for, foreach, while, do while

        for (int counter = 10; counter < 200; counter++)
        {
            Console.Write(100 + " ");
        }

        // Print numbers from 1 - 100 in console
        for (int counter = 1; counter <= 100; counter = counter + 1)
        {
            Console.Write(counter + " ");
        }

        int counterx = 1;
        while (counterx <= 100)
        {
            Console.Write(counterx + " ");

            counterx = counterx + 1;
        }

        // Print "Hello" until user press "y" in the console
        // While and Do -while can only implement this, we can't use for loop for this solution
        char yes = 'y';
        while (yes == 'y')
        {
            Console.WriteLine("Hello");
            Console.Write("Print another hello?:");
            var keyPressed = Console.ReadKey();
            yes = keyPressed.KeyChar;
        }


        // Print all even numbers upto 100
        for (int counter = 2; counter <= 100; counter = counter + 2)
        {
            Console.Write(counter + " ");
        }

        for (int counter = 1; counter <= 100; counter++)
        {
            if (counter % 2 == 0)
            {
                Console.Write(counter + " ");
            }
        }

        // 3X3
        // 1 2 3
        // 4 5 6
        // 7 8 9


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
    }
}




//CW
//Print multiplication table for 8
// 8 * 1 = 8
// 8 * 2 = 16
// 8 * 3 = 24
// ....
// 8 * 10 = 80

// for (int i = 1; i <= 10; i++)
// {
//     int product = 8 * i;
//     Console.WriteLine($"8 * {i} = {product}");
// }
