using System;
using System.Collections.Generic;
using LivingThings;

class Collection
{
    public void LearnList()
    {
        //string[] names = { "Bishnu", "Ram", "Tek" };

        List<string> nameList = new List<string>();
        nameList.Add("Bishnu");
        nameList.Add("Ram");

        List<byte> ages = new List<byte>() { 23, 45, 34, 78, 9, 45, 67, 78, 12, 11, 23, 43, 54, 65 };

        List<Person> people = new List<Person>();

        // CW - Define list of 10 even numbers.

        var collection1 = new List<string> { "bishnu", "334", "false", "34.67" };

        // Stack and queue
        Stack<string> plates = new Stack<string>(); //LIFO
        plates.Push("Plate1");
        plates.Push("Plate2");
        plates.Push("Plate3");
        plates.Push("Plate4");
        plates.Pop();

        foreach (var item in plates)
        {
            Console.WriteLine(item);
        }

        Queue<string> plateKoLine = new Queue<string>(); //FIFO
        plateKoLine.Enqueue("Plate1");
        plateKoLine.Enqueue("Plate2");
        plateKoLine.Enqueue("Plate3");
        plateKoLine.Dequeue();

        // CW - Print items on queue        
    }

    public void LearnDictionary()
    {
        Dictionary<string, string> countryCapitals = new();
        countryCapitals.Add("Nepal", "Kathmandu");
        countryCapitals.Add("India", "Delhi");
        countryCapitals.Add("China", "Beijing");
        countryCapitals.Add("Bhutan", "sjflkafdj");

        foreach (var item in countryCapitals)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }

        // CW - Define a dictionary to hold coutry and its populalation.
        //      Print output as following:
        //      
        //      Coutry              Population
        //      ----------------------------------
        //      Nepal               39238400
        //      India               1234567000

    }
}
