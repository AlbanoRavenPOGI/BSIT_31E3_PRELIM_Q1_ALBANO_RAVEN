using TransportChallenge;

public class Helicopter : Vehicle, IFlyable, IDriveable
{
    public Helicopter() : base("Helicopter") { }

    public override string Move() => $"{Fly()} {Drive()}";

    public string Fly() => "Flying in the sky.";
    public string Drive() => "Driving on the road.";
}