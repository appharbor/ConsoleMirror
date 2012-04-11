## ConsoleMirror by AppHarbor

ConsoleMirror is a simple utility that allows you to capture the console output of 
`Console.Write()` and `Console.WriteLine()` calls within your .NET console applications.

### Installation

[ConsoleMirror is available on NuGet](https://nuget.org/packages/ConsoleMirror) and works on .NET 2.0+

### Sample usage

```csharp
    using System;
    using NLog;

    namespace WorkerDemo
    {
        class Program
        {
            private static Logger logger = LogManager.GetCurrentClassLogger();
            static void Main(string[] args)
            {
                ConsoleMirror.Initialize();

                try
                {
                    Console.WriteLine("Hello world!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }

                logger.Info(ConsoleMirror.Captured);
            }
        }
    }
```

The output is both captured into `ConsoleMirror.Captured` as well as displayed on the screen.