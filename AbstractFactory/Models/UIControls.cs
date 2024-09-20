using AbstractFactory.Contracts;

namespace AbstractFactory.Models;

public class UIControls
{
    public UIControls(Button button, Checkbox checkbox, ToggleSwitch toggleSwitch)
    {
        Button = button;
        Checkbox = checkbox;
        ToggleSwitch = toggleSwitch;
    }

    public Button Button { get; set; }
    public Checkbox Checkbox { get; set; }
    public ToggleSwitch ToggleSwitch { get; set; } 
}