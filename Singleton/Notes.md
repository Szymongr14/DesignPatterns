### 1. Nowadays is make no sense to write our own implementations of singleton services
- usually we use DI Containers for that 
 
```C#
Services.AddSingleton<IService, Service>();
```

### 2. Singleton general UML diagram
![img.png](img.png)

- We should avoid using Singleton services very often, but in some cases it is relevant to use it (i.e., configuration services)