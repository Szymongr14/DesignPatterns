namespace Observer;

public interface ISubject
{
    public void AddObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);
    public void NotifyObservers();
    public void SetFields(string mail);
    public bool HasChanged();
    public void SetChange(bool status);
}