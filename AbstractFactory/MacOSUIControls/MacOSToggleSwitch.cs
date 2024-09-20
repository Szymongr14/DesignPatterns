using AbstractFactory.Contracts;

namespace AbstractFactory.MacOSUIControls;

public class MacOSToggleSwitch : ToggleSwitch
{
    public MacOSToggleSwitch(ControlsSize size, Color backgroundColor, bool defaultToggled) : base(size, backgroundColor, defaultToggled)
    {
    }

    public override void UseToggleSwitch()
    {
        Console.WriteLine($"MacOS ToggleSwitch: Size: {Size}, BackgroundColor: {BackgroundColor}, DefaultToggled: {DefaultToggled} is being used");
    }
}