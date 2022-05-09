// See https://aka.ms/new-console-template for more information

using Adapter;

Console.WriteLine("Adapter");

ICityAdapter adapter = new CityAdapter();
var city = adapter.GetCity();

Console.WriteLine($"{city.FullName}, {city.Inhabitants}");
Console.ReadLine();