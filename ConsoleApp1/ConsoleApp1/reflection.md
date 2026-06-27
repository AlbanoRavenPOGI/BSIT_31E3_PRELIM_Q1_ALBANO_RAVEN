# Reflection

1. **Why did you use inheritance?**  
   Because all transports share common identity as a Vehicle.

2. **Why did you use interfaces?**  
   To represent abilities (Drive, Fly, Sail) that can be mixed throughout the classes.

3. **Can Helicopter inherit from both Vehicle and Airplane? Why or why not?**  
   No, C# only supports single inheritance. That’s why we use interfaces.

4. **Why can Helicopter implement both IFlyable and IDriveable?**  
   Because interfaces allow multiple implementations, unlike classes.

5. **If a Submarine can both sail and dive, how would you design it?**  
   `Submarine : Vehicle, ISailable, IDiveable` (where `IDiveable` is a new interface).
