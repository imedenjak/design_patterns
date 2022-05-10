namespace PP_Decorator;

/// <summary>
/// Decorator class - specific decorator - IS a decorator
/// </summary>
public class RibbonHat : HatDecorator
{
    private const int RibbonPrice = 100;
    private const string RibbonDesc = "ribboned";

    public RibbonHat(IHat decoratedHat) :
        base(decoratedHat)
    {
    }

    public override int Price => base.Price + RibbonPrice;
    public override string Description => $"{base.Description}, {RibbonDesc}";
}