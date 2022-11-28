using System;

class Mansion : House //Single Inheritance
{
    public Mansion()
    {                
    }

    public Mansion(short nf, short nr) : base(nf, nr)
    {        
    }

    float swimmingPoolArea;
    float numberOfHelipads;

    void CallServant()
    {
        Console.WriteLine("Need to clean swimming pool, plese come!");
    }
}

class Palace : Mansion  // Multi-level inheritance
{
    short numberOfRoyalGuards;                
}

// Example 2
class A
{
    public virtual void Sleep()
    {
        
    }

    public virtual float Sleep(int x, float r)
    {
        return r + x;
    }    
}

public interface IB
{
    public void Start()
    {

    }

    public void Stop()
    {

    }
}

class C : IB
{

}

class D: A, IB  // Multiple inheritance
{
    public override float Sleep(int x, float y)
    {
        return 45.6f;
    }
}

abstract class School
{
    
}