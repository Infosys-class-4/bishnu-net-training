class Employee
{
    // Auto-implemented property
    public float Salary { get; set; }
    public int age;
    private string name; 

    // Full property definition
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if(value.Length > 2)
                name = value;
        }
    }
}
