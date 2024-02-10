namespace Liskov_Substitution_Principle;

// Derived class
public class Ostrich : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Ostrich can't fly!");
    }
}