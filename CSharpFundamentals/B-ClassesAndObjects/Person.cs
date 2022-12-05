// Programming Paradigms

// Procedural: C, PASCAL, BASIC, Go
// Imeprative: Go, C#, C, C++
// Declarative: Python, C#
// Object Oriented: C#, Java, Python, C++
// Functional: F#, Scala, Haskell, C#
// Dynamic: JS, Ruby, Pyhton
// Static: C#, Java, C++, C

// C# is multi-paradigm language
namespace LivingThings;
class Person
{
    public static string sName = "Homo Sepians";
    public string name;
    public byte age;

    public string GetLegalGreeting()
    {
        if (age < 18)
        {
            return "Oops, you are still under age!";
        }
        else
        {
            return "You are adult now!";
        }
    }
}
