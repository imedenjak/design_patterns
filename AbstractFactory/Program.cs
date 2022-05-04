using AbstractFactory;

Console.Title = "Abstract Factory";

var croatianShoppingCartPurchaseFactory = new CroatianShoppingCartPurchaseFactory();
var shoppingCartForCroatia = new ShoppingCart(croatianShoppingCartPurchaseFactory);
shoppingCartForCroatia.CalculateCosts();

var franceShoppingCartPurchaseFactory = new FranceShoppingCardPurchaseFactory();
var shoppingCartForFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);
shoppingCartForFrance.CalculateCosts();

Console.ReadKey();