namespace Decorator;

public class FileManager : IFileManager
{
    public void Write(string fileName, string content)
    {
        if (!File.Exists(fileName))
        {
            using FileStream fs = File.Create(fileName);
        }
        File.WriteAllText(fileName, content);
    }

    public string Read(string fileName)
    {
        return File.ReadAllText(fileName);
    }
}