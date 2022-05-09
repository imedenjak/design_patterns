// See https://aka.ms/new-console-template for more information

using PP_Decorator;

Console.WriteLine("Hello, World!");

var standardHat = new StandardHat("Baseball cap");
var premiumHat = new PremiumHat("Top hat");

IHat hat = new RibbonHat(new GoldenHat(standardHat));
Console.WriteLine($"{hat.Description} \t\t {hat.Price}");

hat = new RibbonHat(new GoldenHat(premiumHat));
Console.WriteLine($"{hat.Description} \t\t {hat.Price}");

hat = new GoldenHat(standardHat);
Console.WriteLine($"{hat.Description} \t {hat.Price}");

hat = new RibbonHat(premiumHat);
Console.WriteLine($"{hat.Description} \t {hat.Price}");


Console.ReadLine();