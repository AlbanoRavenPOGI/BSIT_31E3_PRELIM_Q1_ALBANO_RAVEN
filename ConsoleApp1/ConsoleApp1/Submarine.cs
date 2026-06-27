using TransportChallenge;

public class Submarine : Vehicle, ISailable, IDriveable
{
    public Submarine() : base("Submarine") { }

    public override string Move() => $"{Sail()} {Dive()} {Drive()}";

    public string Sail() => "Sailing under the sea surface.";
    public string Dive() => "Diving deep underwater.";
    public string Drive() => "Navigating underwater using propellers.";
}