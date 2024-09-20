using AbstractFactory.Contracts;
using AbstractFactory.MacOSUIControls;
using AbstractFactory.WindowsUIControls;

namespace AbstractFactory.UIControlsFactories;

public class MacOSUIControlsFactory : IUIControlsFactory
{
    public Button CreateButton(ControlsSize size, Color backgroundColor)
    {
        return new MacOSButton(size, backgroundColor);
    }

    public Checkbox CreateCheckbox(ControlsSize size, Color backgroundColor, bool defaultChecked)
    {
        return new MacOSCheckbox(size, backgroundColor, defaultChecked);
    }

    public ToggleSwitch CreateToggleSwitch(ControlsSize size, Color backgroundColor, bool defaultToggled)
    {
        return new MacOSToggleSwitch(size, backgroundColor, defaultToggled);
    }
}