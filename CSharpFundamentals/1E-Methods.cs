using System;
class Methods
{
    // Returns nothing, takes no arguments
    public void Print()
    {
        Console.WriteLine("I am a simple method");
    }

    // Retunrs nothing, takes some arguments
    public void PrintSomething(string message)
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
    public (byte, byte) GetMinMax(byte[] nums)
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
}
