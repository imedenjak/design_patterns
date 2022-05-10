namespace PP_Decorator;

/// <summary>
/// Decorator class - specific decorator - IS a decorator
/// </summary>
public class GoldenHat : HatDecorator
{
    private const int GoldenPriceStd = 200;
    private const int GoldenPricePrem = 1000;
    private const string GoldenDesc = "Golden";

    public GoldenHat(IHat decoratedHat) :
        base(decoratedHat)
    {
    }

    public override int Price => base.Price + (IsPremium ? GoldenPricePrem : GoldenPriceStd);
    public override string Description => $"{GoldenDesc} {base.Description}";
}