// See https://aka.ms/new-console-template for more information

using PP_Adapter;

Console.WriteLine("Hello, World!");

var goldenHat = new HatAdapter(new Hat("Golden hat", "Golden hat",4999));
var pointyHat = new HatAdapter(new Hat("Pointy hat", "Pointy hat", 3000));
var purpleHat = new HatAdapter(new Hat("Purple hat", "Purple hat",1490));

ShoppingCart shoppingCart = new ShoppingCart();

shoppingCart.Add(goldenHat);
shoppingCart.Add(pointyHat);
shoppingCart.Add(purpleHat);

shoppingCart.Remove(pointyHat);

Console.WriteLine(shoppingCart.GetReceipt());

Console.ReadLine();