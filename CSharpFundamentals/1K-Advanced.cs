using System;
using System.Threading;
using System.Threading.Tasks;

class Advanced
{
    public void Test()
    {
        // Sequential
        Console.WriteLine("Sequential Loop:");
        for(int i = 10; i < 20; i++)
        {
            var p = FindNthPrime(i);
            Console.WriteLine($"{i}th prime number is {p}");
        }

        // Parallel Way
        Console.WriteLine("Parallel Loop:");
        Parallel.For(10, 20, (i)=> {
            var p = FindNthPrime(i);
            Console.WriteLine($"{i}th prime number is {p}");
        });
    }

    async Task Test2()
    {
        // async and await
        // Asynchronous programming : Non-blocking
        var a = await DoSomething(34);
        var b = await DoSomething(a);
        var c = await DoSomething(3453);
    }   

    Task<int> DoSomething(int x)
    {
        Task.Delay(500);
        return Task.FromResult(123123);
    }

    double FindNthPrime(int n)
    {
        // Calculate prime
        Thread.Sleep(1000);
        return 0;
    }
}