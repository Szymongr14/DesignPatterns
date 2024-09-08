using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace Observer;

public class Client : IObserver
{
    public string Name { get; set; }

    public Client(string name)
    {
        Name = name;
    }

    private void ReadMail(string mail)
    {
        Console.WriteLine($"Client {Name}'s received mail: {mail}");
    }

    public void Update(string mail)
    {
        ReadMail(mail);
    }
}