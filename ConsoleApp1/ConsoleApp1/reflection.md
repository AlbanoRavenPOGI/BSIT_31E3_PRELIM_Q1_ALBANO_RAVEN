# Reflection

**1. Why did you use inheritance?** 
Because all transports share common identity as a Vehicle.
It helps reuse common properties and methods instead of rewriting them for every class.

**2. Why did you use interfaces?** 
To represent abilities (Drive, Fly, Sail) that can be mixed throughout the classes.
Interfaces make the design flexible so different vehicles can have different capabilities.

**3. Can Helicopter inherit from both Vehicle and Airplane? Why or why not?**
No, C# only supports single inheritance. That’s why we use interfaces.
This prevents confusion and keeps the class hierarchy simple.

**4. Why can Helicopter implement both IFlyable and IDriveable?** 
Because interfaces allow multiple implementations, unlike classes.
It shows that a helicopter can perform more than one action at the same time.

**5. If a Submarine can both sail and dive, how would you design it?**
Submarine : Vehicle, ISailable, IDiveable (where IDiveable is a new interface).
The submarine can have both sailing and diving behaviors without breaking the rules of inheritance.
