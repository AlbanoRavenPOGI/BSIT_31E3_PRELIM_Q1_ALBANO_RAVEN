namespace TransportChallenge;

public class Car : Vehicle, IDriveable
{
    public Car() : base("Car") { }

    public override string Move() => Drive();

    public string Drive() => "Driving on the road.";
}
