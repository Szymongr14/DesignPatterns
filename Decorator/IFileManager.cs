namespace Decorator;

public interface IFileManager
{
    public void Write(string fileName, string content);
    public string Read(string fileName);
}