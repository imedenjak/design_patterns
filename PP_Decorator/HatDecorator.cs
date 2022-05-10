namespace PP_Decorator;

/// <summary>
/// Base decorator - IS a thing, wraps and adds features to it
/// </summary>
public abstract class HatDecorator : IHat
{
    private readonly IHat _decoratedHat;
    protected HatDecorator(IHat decoratedHat)
    {
        _decoratedHat = decoratedHat;
    }
    public virtual string Name => _decoratedHat.Name;
    public virtual int Price => _decoratedHat.Price;
    public virtual string Description => _decoratedHat.Description;
    public virtual bool IsPremium => _decoratedHat.IsPremium;
}