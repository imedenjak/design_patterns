// See https://aka.ms/new-console-template for more information

using PP_Composite;

var firstOrder = new MultipleOrder();
firstOrder.Add(new ItemOrder("1234", "Baseball cap", 2000));
firstOrder.Add(new ItemOrder("8888", "Party Hat", 3000));

var secondOrder = new MultipleOrder();
secondOrder.Add(new ItemOrder("3333", "Joker Hat", 3200));
secondOrder.Add(new ItemOrder("4321", "Beanie", 2500));

var order = new MultipleOrder();
order.Add(firstOrder);
order.Add(secondOrder);

Console.WriteLine(order.Description);
Console.WriteLine($"{Environment.NewLine}Total: € {order.Price}");

Console.WriteLine();