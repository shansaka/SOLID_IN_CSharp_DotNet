namespace Interface_Segregation_Principle;

// Class implementing interfaces
public class NormalWorker : IWorker
{
    public void Work()
    {
        Console.WriteLine("NormalWorker is working...");
    }
}