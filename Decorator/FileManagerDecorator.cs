namespace Decorator;

public abstract class FileManagerDecorator : IFileManager
{
    private readonly IFileManager _fileManager;

    protected FileManagerDecorator(IFileManager fileManager)
    {
        _fileManager = fileManager;
    }

    public virtual void Write(string fileName, string content)
    {
        _fileManager.Write(fileName, content);
    }

    public virtual string Read(string fileName)
    {
        return _fileManager.Read(fileName);
    }
}