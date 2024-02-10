// Class implementing interfaces
namespace Interface_Segregation_Principle;

public class SuperWorker : IWorker, IEater, ISleeper
{
    public void Work()
    {
        Console.WriteLine("SuperWorker is working...");
    }

    public void Eat()
    {
        Console.WriteLine("SuperWorker is eating...");
    }

    public void Sleep()
    {
        Console.WriteLine("SuperWorker is sleeping...");
    }
}