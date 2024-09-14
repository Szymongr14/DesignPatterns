using Decorator;
using Decorator.Decorators;

var cryptoFileManager = new CryptographyDecorator(new FileManager(), "password");
var normalFileManager = new FileManager();

cryptoFileManager.Write("testFile", "content to write");
Console.WriteLine($"Read content inside file using file manager without decorator: {normalFileManager.Read("testFile")}");
Console.WriteLine($"Read content inside file using file manager with cryptographic functions: {cryptoFileManager.Read("testFile")}");


