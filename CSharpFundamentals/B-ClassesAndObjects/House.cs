
/* CW: Think of a real world class which contains: 
    - 3 fields, 
    - a parameterless constructor, 
    - a constructor with 2 parameters and 
    - a method
    - a property with full definition
    - a read only property
*/
class House
{
    bool haveGarage;
    short numberOfFloors;
    short numberOfRooms;
    public float Length { get; set; }
    public float Width { get; set; }

    public House()
    {        
    }

    public House(short nof, short nor)
    {
        numberOfFloors = nof;
        numberOfRooms = nor;
    }

    public House(short nof, short nor, float l, float w)
    {
        numberOfFloors = nof;
        numberOfRooms = nor;
        Length = l;
        Width = w;
    }

    public float GetAreaOfChat() => Length * Width;
    
}
