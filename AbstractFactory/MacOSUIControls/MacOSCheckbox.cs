using AbstractFactory.Contracts;

namespace AbstractFactory.MacOSUIControls;

public class MacOSCheckbox : Checkbox
{
    public MacOSCheckbox(ControlsSize size, Color backgroundColor, bool defaultChecked) : base(size, backgroundColor, defaultChecked)
    {
    }

    public override void UseCheckbox()
    {
        Console.WriteLine($"MacOS Checkbox: Size: {Size}, BackgroundColor: {BackgroundColor}, DefaultChecked: {DefaultChecked} is being used");
    }
}