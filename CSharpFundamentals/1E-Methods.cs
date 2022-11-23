using System;
class Methods
{
    // Returns nothing, takes no arguments
    public void Print()
    {
        Console.WriteLine("I am a simple method");
    }

    // Retunrs nothing, takes some arguments
    public void Print(string message)
    {
        Console.WriteLine(message);
    }

    // Returns something, takes some arguments
    // num3 is optional
    public double Add(double num1, double num2, double num3 = 0)
    {
        var sum = num1 + num2 + num3;
        return sum;
    }

    // Expression bodied members
    public double AddNumbers(double num1, double num2, double num3 = 0) => num1 + num2 + num3;
       
    // returns something, takes arbitrary number of arguments
    public long Multiply(params int[] numbers)
    {
        long product = 1;
        foreach(int num in numbers) // {3, 4, 7, 8}
        {
            product = product * num;
            //product *= num;
        }

        return product;
    }

    // returns multiple values, takes some arguments
    public (byte, byte) GetMinMax(params byte[] nums)
    {
        byte min = byte.MaxValue, max = byte.MinValue;
        foreach(byte n in nums) // nums={2,3,1,4}
        {
            if(n < min)
            {
                min = n;
            }
            if(n > max)
            {
                max = n;
            }
        }

        return (min, max);
    }

    // CW1: write a method which returns average of all 4 numbers supplied as parameter.

    public float CalculateAverage(short n1, short n2, short n3, short n4)
    {
        float average = ((float)n1 + n2 + n3 + n4) / 4;
        return average;
    }

    // CW: Modify above method to take array of numbers and calculate average of all.
    public float CalculateAverage(float[] numbers)
    {
        float average = 0;
        float sum = 0;
        foreach(short num in numbers)
        {
            sum = sum + num;
        }
        average = sum / numbers.Length ;

        return average;
    }
 
    // CW - Modify same method to return average and minimum of all.
    public (float, short) CalculateAverageAndMinimum(params short[] numbers)
    {
        float average = 0;
        float sum = 0;
        short min = short.MaxValue;

        foreach(short num in numbers)
        {
            sum = sum + num;
            if(num < min)
            {
                min = num;
            }
        }

        average = sum / numbers.Length ;

        return (average, min);
    }


}
