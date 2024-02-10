using Dependency_Inversion_Principle;

LightBulb bulb = new LightBulb();
ElectricPowerSwitch powerSwitch = new ElectricPowerSwitch(bulb);

powerSwitch.Press(); // Output: Light bulb turned on

// Now, let's change the device to something else, like a fan
Fan fan = new Fan();
powerSwitch.SwitchableDevice = fan;

powerSwitch.Press(); // Output: Fan turned on