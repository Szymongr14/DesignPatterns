using Singleton;

var task1 = new Task(() =>
{
    var singletonService = SingletonService.GetInstance();
    Console.WriteLine($"Task 1: {singletonService.ServiceId}");
});

var task2 = new Task(() =>
{
    var singletonService = SingletonService.GetInstance();
    Console.WriteLine($"Task 2: {singletonService.ServiceId}");
});

task1.Start();
task2.Start();

Task.WaitAll(task1, task2);
