// See https://aka.ms/new-console-template for more information

using PP_Adapter;

Console.WriteLine("Hello, World!");

// Client talks to Compatible thing - Item
Item goldenHat = new HatAdapter(new Hat("Golden hat", "Golden hat",4999));
Item pointyHat = new HatAdapter(new Hat("Pointy hat", "Pointy hat", 3000));
Item purpleHat = new HatAdapter(new Hat("Purple hat", "Purple hat",1490));

ShoppingCart shoppingCart = new ShoppingCart();

shoppingCart.Add(goldenHat);
shoppingCart.Add(pointyHat);
shoppingCart.Add(purpleHat);

shoppingCart.Remove(pointyHat);

Console.WriteLine(shoppingCart.GetReceipt());

Console.ReadLine();