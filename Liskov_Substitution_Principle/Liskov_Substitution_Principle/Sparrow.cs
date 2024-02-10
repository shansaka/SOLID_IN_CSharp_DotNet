namespace Liskov_Substitution_Principle;

// Derived class
public class Sparrow : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Sparrow is flying...");
    }
}