namespace AbstractFactory.Contracts;

public abstract class Button
{
    protected ControlsSize Size { get; set; }
    protected Color BackgroundColor { get; set; }

    protected Button(ControlsSize size, Color backgroundColor)
    {
        Size = size;
        BackgroundColor = backgroundColor;
    }

    public abstract void UseButton();
}