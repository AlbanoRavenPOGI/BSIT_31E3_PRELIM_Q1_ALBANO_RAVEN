using TransportChallenge;

public class Drone : Vehicle, IFlyable
{
    public Drone() : base("Drone") { }

    public override string Move() => Fly();

    public string Fly() => "Flying remotely in the air.";
}