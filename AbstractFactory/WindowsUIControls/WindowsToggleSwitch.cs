using AbstractFactory.Contracts;

namespace AbstractFactory.WindowsUIControls;

public class WindowsToggleSwitch : ToggleSwitch
{
    public WindowsToggleSwitch(ControlsSize size, Color backgroundColor, bool defaultToggled) : base(size, backgroundColor, defaultToggled)
    {
    }

    public override void UseToggleSwitch()
    {
        Console.WriteLine($"Windows ToggleSwitch: Size: {Size}, BackgroundColor: {BackgroundColor}, DefaultToggled: {DefaultToggled} is being used");
    }
}