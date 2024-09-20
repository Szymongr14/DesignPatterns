using AbstractFactory.Contracts;

namespace AbstractFactory.WindowsUIControls;

public class WindowsButton : Button
{
    public WindowsButton(ControlsSize size, Color backgroundColor) : base(size, backgroundColor)
    {
    }

    public override void UseButton()
    {
        Console.WriteLine($"Windows Button: Size: {Size}, BackgroundColor: {BackgroundColor} is being used");
    }
}