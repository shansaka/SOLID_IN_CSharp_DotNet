namespace Dependency_Inversion_Principle;

// High-level module
public class ElectricPowerSwitch
{
    public ISwitchable SwitchableDevice { get; set; }

    public ElectricPowerSwitch(ISwitchable device)
    {
        SwitchableDevice = device;
    }

    public void Press()
    {
        if (SwitchableDevice == null)
            return;

        if (SwitchableDevice is LightBulb bulb)
        {
            bulb.TurnOn();
        }
        else
        {
            SwitchableDevice.TurnOn();
        }
    }
}