using AbstractFactory.Contracts;
using AbstractFactory.WindowsUIControls;

namespace AbstractFactory.UIControlsFactories;

public class WindowsUIControlsFactory : IUIControlsFactory
{
    public Button CreateButton(ControlsSize size, Color backgroundColor)
    {
        return new WindowsButton(size, backgroundColor);
    }

    public Checkbox CreateCheckbox(ControlsSize size, Color backgroundColor, bool defaultChecked)
    {
        return new WindowsCheckbox(size, backgroundColor, defaultChecked);
    }

    public ToggleSwitch CreateToggleSwitch(ControlsSize size, Color backgroundColor, bool defaultToggled)
    {
        return new WindowsToggleSwitch(size, backgroundColor, defaultToggled);
    }
}