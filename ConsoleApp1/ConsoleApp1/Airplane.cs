namespace TransportChallenge;

public class Airplane : Vehicle, IFlyable
{
    public Airplane() : base("Airplane") { }

    public override string Move() => Fly();

    public string Fly() => "Flying in the sky.";
}
