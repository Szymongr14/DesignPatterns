namespace AbstractFactory.Contracts;

public abstract class Checkbox
{
    protected ControlsSize Size { get; set; }
    protected Color BackgroundColor { get; set; }
    protected bool DefaultChecked { get; set; }
    
    protected Checkbox(ControlsSize size, Color backgroundColor, bool defaultChecked)
    {
        Size = size;
        BackgroundColor = backgroundColor;
        DefaultChecked = defaultChecked;
    }
    
    public abstract void UseCheckbox();
}