namespace AbstractFactory.Contracts;

public abstract class ToggleSwitch
{
    protected ControlsSize Size { get; set; }
    protected Color BackgroundColor { get; set; }
    protected bool DefaultToggled { get; set; }

    protected ToggleSwitch(ControlsSize size, Color backgroundColor, bool defaultToggled)
    {
        Size = size;
        BackgroundColor = backgroundColor;
        DefaultToggled = defaultToggled;
    }

    public abstract void UseToggleSwitch();
}