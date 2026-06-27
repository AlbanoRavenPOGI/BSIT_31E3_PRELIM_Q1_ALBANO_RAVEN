public abstract class Vehicle
{
    public string Name { get; set; }
    protected Vehicle(string name) { Name = name; }

    public abstract string Move(); 
}
