using System;
using System.Collections.Generic;
using System.Text;
using TransportChallenge;

namespace TransportChallenge;

public class Motorcycle : Vehicle, IDriveable
{
    public Motorcycle() : base("Motorcycle") { }

    public override string Move() => Drive();

    public string Drive() => "Driving fast on the road.";
}
