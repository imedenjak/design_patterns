namespace PP_Decorator;

/// <summary>
/// Decorator class
/// </summary>
public class GoldenHat : IHat
{
    private const int GoldenPriceStd = 200;
    private const int GoldenPricePrem = 1000;
    private const string GoldenDesc = "Golden";
    
    private readonly IHat _decoratedHat;

    public GoldenHat(IHat decoratedHat)
    {
        _decoratedHat = decoratedHat;
    }

    public string Name => _decoratedHat.Name;
    public int Price => _decoratedHat.Price + (IsPremium ? GoldenPricePrem : GoldenPriceStd);
    public string Description => $"{GoldenDesc} {_decoratedHat.Description}";
    public bool IsPremium => _decoratedHat.IsPremium;
}