namespace PP_Decorator;

public abstract class HatDecorator : IHat
{
    protected readonly IHat _decoratedHat;
    public HatDecorator(IHat decoratedHat)
    {
        _decoratedHat = decoratedHat;
    }
    
    public string Name => _decoratedHat.Name;
    public abstract int Price { get; } 
    public virtual string Description { get; } = string.Empty;
    public abstract bool IsPremium { get; }
}