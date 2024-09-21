namespace Singleton;

public class SingletonService
{
    private static SingletonService _instance;
    private static readonly object _lock = new();
    public Guid ServiceId { get; private set; }

    private SingletonService(){ }

    public static SingletonService GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                _instance ??= new SingletonService();
                _instance.ServiceId = new Guid();
            }
        }

        return _instance;
    }
}