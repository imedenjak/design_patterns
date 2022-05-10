namespace PP_Adapter;

/// <summary>
/// IS a Compatible thing and HAS a Incompatible thing
/// </summary>
public class HatAdapter : Item
{
    private Hat Hat { get; }

    public HatAdapter(Hat hat)
    {
        Hat = hat;
    }

    public override string ItemName => Hat.ShortName + Hat.LongName;
    public override int ItemPrice => Hat.Price;
}