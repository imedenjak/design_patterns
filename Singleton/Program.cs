// See https://aka.ms/new-console-template for more information

using Singleton;

Console.WriteLine("Hello, World!");

var logger1 = Logger.Instance;
var logger2 = Logger.Instance;

if (logger1 == logger2 && logger2 == Logger.Instance)
{
    Console.WriteLine("Instances are the same.");
}

logger1.Log($"Message from {nameof(logger1)}");
logger2.Log($"Message form {nameof(logger2)}");

Console.ReadKey();