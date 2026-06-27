namespace TransportChallenge;

public class Boat : Vehicle, ISailable
{
    public Boat() : base("Boat") { }

    public override string Move() => Sail();

    public string Sail() => "Sailing on the water.";
}
