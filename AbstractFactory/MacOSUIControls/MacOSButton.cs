using AbstractFactory.Contracts;

namespace AbstractFactory.MacOSUIControls;

public class MacOSButton : Button
{
    public MacOSButton(ControlsSize size, Color backgroundColor) : base(size, backgroundColor)
    {
    }

    public override void UseButton()
    {
        Console.WriteLine($"MacOS Button: Size: {Size}, BackgroundColor: {BackgroundColor} is being used");
    }
}