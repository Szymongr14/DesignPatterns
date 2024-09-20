using AbstractFactory;
using AbstractFactory.Contracts;
using OperatingSystem = AbstractFactory.OperatingSystem;


// creating controls for windows
var windowsControls = UIControlsFactoryProvider.
    Initialize().
    CreateControls(OperatingSystem.Windows, ControlsSize.Medium, Color.Blue, true);

// using windows controls
windowsControls.ToggleSwitch.UseToggleSwitch();
windowsControls.Button.UseButton();
windowsControls.Checkbox.UseCheckbox();

// creating controls for macOS
var macOSControls = UIControlsFactoryProvider.
    Initialize().
    CreateControls(OperatingSystem.MacOS, ControlsSize.Small, Color.Red, false);

// using macOS controls
macOSControls.ToggleSwitch.UseToggleSwitch();
macOSControls.Button.UseButton();
macOSControls.Checkbox.UseCheckbox();
    