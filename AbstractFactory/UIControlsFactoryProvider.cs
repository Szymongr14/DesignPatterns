using AbstractFactory.Contracts;
using AbstractFactory.Models;
using AbstractFactory.UIControlsFactories;

namespace AbstractFactory;

public class UIControlsFactoryProvider
{
    private readonly Dictionary<OperatingSystem, IUIControlsFactory> _controlsFactories;

    private UIControlsFactoryProvider()
    {
        // normal initialization
        _controlsFactories = new Dictionary<OperatingSystem, IUIControlsFactory>
        {
            { OperatingSystem.Windows, new WindowsUIControlsFactory() },
            { OperatingSystem.MacOS, new MacOSUIControlsFactory() }
        };
        
        // we could use reflection to get all classes that implement IUIControlsFactory
    }
    
    public static UIControlsFactoryProvider Initialize()
    {
        return new UIControlsFactoryProvider();
    }
    
    private IUIControlsFactory GetFactory(OperatingSystem os)
    {
        return _controlsFactories[os];
    }
    
    public UIControls CreateControls(OperatingSystem os, ControlsSize size, Color backgroundColor, bool defaultChecked)
    {
        var factory = GetFactory(os);
        return new UIControls(
            factory.CreateButton(size, backgroundColor),
            factory.CreateCheckbox(size, backgroundColor, defaultChecked),
            factory.CreateToggleSwitch(size, backgroundColor, defaultChecked)
        );
    }
}