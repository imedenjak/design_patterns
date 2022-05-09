namespace PP_Decorator;

/// <summary>
/// Decorator class
/// </summary>
public class RibbonedHat : HatDecorator
{
    private const int RibbonedPrice = 100;
    private const string RibbonedDesc = "ribboned";

    public RibbonedHat(IHat decoratedHat) :
        base(decoratedHat)
    {
    }
    public override int  Price => _decoratedHat.Price + RibbonedPrice;
    public override string Description => $"{_decoratedHat.Description}, {RibbonedDesc}";
    public override bool IsPremium => _decoratedHat.IsPremium;
}