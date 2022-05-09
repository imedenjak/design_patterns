namespace PP_Adapter;

public class Hat
{
    public string ShortName { get; }
    public string LongName { get; }
    public int Price { get; }

    public Hat(string shortName, string longName, int price)
    {
        ShortName = shortName;
        LongName = longName;
        Price = price;
    }
}