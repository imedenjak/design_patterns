using System.Text;

namespace PP_Adapter;

/// <summary>
/// External class
/// </summary>
public class ShoppingCart
{
    private readonly List<Item> _items = new ();

    public void Add(Item item)
    {
        _items.Add(item);
    }

    public bool Remove(Item item)
    {
        return _items.Remove(item);
    }

    private long GetTotalPrice()
    {
        long result = 0;
        foreach (var item in _items)
        {
            result += item.ItemPrice;
        }
        return result;
    }

    public string GetReceipt()
    {
        var result = new StringBuilder();
        foreach (var item in _items)
        {
            result.Append($"{item.ItemName} \t {FormatMoney(item.ItemPrice)} {Environment.NewLine}");
        }

        result.Append($"-------------------------- {Environment.NewLine}");
        result.Append($"Total:\t\t { FormatMoney(GetTotalPrice())} {Environment.NewLine}");
        return result.ToString();
    }

    private static string FormatMoney(long money)
    {
        return $"€ {money / 100} . {money % 100}";
    }
}