namespace AbstractFactory.Contracts;

public interface IUIControlsFactory
{
    Button CreateButton(ControlsSize size, Color backgroundColor);
    Checkbox CreateCheckbox(ControlsSize size, Color backgroundColor, bool defaultChecked);
    ToggleSwitch CreateToggleSwitch(ControlsSize size, Color backgroundColor, bool defaultToggled);
}