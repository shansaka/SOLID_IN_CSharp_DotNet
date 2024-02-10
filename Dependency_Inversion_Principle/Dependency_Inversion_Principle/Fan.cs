namespace Dependency_Inversion_Principle;

// Another low-level module
public class Fan : ISwitchable
{
    public void TurnOn()
    {
        Console.WriteLine("Fan turned on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Fan turned off");
    }
}