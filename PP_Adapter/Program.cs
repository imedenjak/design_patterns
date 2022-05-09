// See https://aka.ms/new-console-template for more information

using PP_Adapter;

Console.WriteLine("Hello, World!");

HatAdapter goldenHat = new HatAdapter(new Hat("Golden hat", "Golden hat",4999));
HatAdapter pointyHat = new HatAdapter(new Hat("Pointy hat", "Pointy hat", 3000));
HatAdapter purpleHat = new HatAdapter(new Hat("Purple hat", "Purple hat",1490));

ShoppingCart shoppingCart = new ShoppingCart();

shoppingCart.add(goldenHat);
shoppingCart.add(pointyHat);
shoppingCart.add(purpleHat);

shoppingCart.remove(pointyHat);

Console.WriteLine(shoppingCart.getReceipt());

Console.ReadLine();