namespace PP_Adapter;

public class HatAdapter : Item
{
    public Hat Hat { get; }

    public HatAdapter(Hat hat)
    {
        Hat = hat;
    }

    public override string itemName => Hat.ShortName;
    public override int itemPrice => Hat.Price;
}