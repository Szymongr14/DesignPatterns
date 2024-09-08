namespace Observer;

public class Newsletter : ISubject
{
    private List<IObserver> _subscribers;
    private string _contentOfMail;
    private bool _FieldsHaveBeenChanged;

    public Newsletter()
    {
        _subscribers = [];
        _contentOfMail = "";
        _FieldsHaveBeenChanged = false;
    }
    
    public void AddObserver(IObserver observer)
    {
        _subscribers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _subscribers.Remove(observer);
    }

    public void NotifyObservers()
    {
        if (!_FieldsHaveBeenChanged) return;
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(_contentOfMail);
        }

        _FieldsHaveBeenChanged = false;
    }

    public void SetFields(string mail)
    {
        if (_contentOfMail.Equals(mail)) return;
        _contentOfMail = mail;
        _FieldsHaveBeenChanged = true;
    }

    public bool HasChanged()
    {
        return _FieldsHaveBeenChanged;
    }

    public void SetChange(bool status)
    {
        _FieldsHaveBeenChanged = status;
    }
}
