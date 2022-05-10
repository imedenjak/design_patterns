namespace PP_Composite;

public class ItemOrder : IOrder
{
    private readonly string _code;
    private readonly string _name;
    public int Price { get; }

    public ItemOrder(string code, string name, int price)
    {
        Price = price;
        _code = code;
        _name = name;
    }

    public string Description => $"{_code} - {_name}".PadRight(25) + $"€ {Price}";
}