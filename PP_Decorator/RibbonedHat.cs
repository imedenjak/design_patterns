namespace PP_Decorator;

/// <summary>
/// Decorator class
/// </summary>
public class RibbonedHat : IHat
{
    private const int RibbonedPrice = 100;
    private const string RibbonedDesc = "ribboned";

    private readonly IHat _decoratedHat;

    public RibbonedHat(IHat decoratedHat)
    {
        _decoratedHat = decoratedHat;
    }

    public string Name => _decoratedHat.Name;
    public int Price => _decoratedHat.Price + RibbonedPrice;
    public string Description => $"{_decoratedHat.Description}, {RibbonedDesc}";
    public bool IsPremium => _decoratedHat.IsPremium;
}