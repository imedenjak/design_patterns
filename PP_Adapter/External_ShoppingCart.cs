using System.Text;

namespace PP_Adapter;

/// <summary>
/// External class
/// </summary>
public class ShoppingCart
{
    private List<Item> items = new ();

    public void add(Item item)
    {
        items.Add(item);
    }

    public bool remove(Item item)
    {
        return items.Remove(item);
    }

    public long getTotalPrice()
    {
        long result = 0;
        foreach (var item in items)
        {
            result += item.itemPrice;
        }
        return result;
    }

    public string getReceipt()
    {
        StringBuilder result = new StringBuilder();
        foreach (var item in items)
        {
            result.Append($"{item.itemName} \t {formatMoney(item.itemPrice)} {Environment.NewLine}");
        }

        result.Append($"-------------------------- {Environment.NewLine}");
        result.Append($"Total:\t\t { formatMoney(getTotalPrice())} {Environment.NewLine}");
        return result.ToString();
    }

    private string formatMoney(long money)
    {
        return $"€ {money / 100} . {money % 100}";
    }
}