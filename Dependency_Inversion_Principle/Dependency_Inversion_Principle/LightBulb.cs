
namespace Dependency_Inversion_Principle;

// Low-level module
public class LightBulb : ISwitchable
{
    public void TurnOn()
    {
        Console.WriteLine("Light bulb turned on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light bulb turned off");
    }
}