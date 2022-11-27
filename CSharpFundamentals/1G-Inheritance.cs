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
