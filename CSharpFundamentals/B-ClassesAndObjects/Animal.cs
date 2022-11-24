namespace LivingThings;
class Animal
{
    // Parameterless constructor - default
    public Animal()
    {
    }

    // Parameterized constructor
    public Animal(string animalCategory, byte legs)
    {
        category = animalCategory;
        numberOfLegs = legs;
    }

    public Animal(string animalCategory, byte legs, string sn, bool d)
    {
        category = animalCategory;
        numberOfLegs = legs;
        domestic = d;
        scientificName = sn;
    }

    public string category;
    public string scientificName;
    public byte numberOfLegs;
    public bool domestic;
}


/* CW: Think of a real world class which contains: 
    - 3 fields, 
    - a parameterless constructor, 
    - a constructor with 2 parameters and 
    - a method
    - a property with full definition
    - a read only property
*/
