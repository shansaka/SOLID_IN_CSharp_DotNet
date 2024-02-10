namespace Liskov_Substitution_Principle;

// Base class
public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Bird is flying...");
    }
}