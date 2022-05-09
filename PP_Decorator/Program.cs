// See https://aka.ms/new-console-template for more information

using PP_Decorator;

Console.WriteLine("Hello, World!");

IHat hat = new RibbonedHat(new GoldenHat(new StandardHat("Baseball cap")));
Console.WriteLine($"{hat.Description} \t\t {hat.Price}");

hat = new RibbonedHat(new GoldenHat(new PremiumHat("Top hat")));
Console.WriteLine($"{hat.Description} \t\t {hat.Price}");

hat = new GoldenHat(new StandardHat("Baseball cap"));
Console.WriteLine($"{hat.Description} \t {hat.Price}");

hat = new RibbonedHat(new PremiumHat("Top cap"));
Console.WriteLine($"{hat.Description} \t {hat.Price}");


Console.ReadLine();