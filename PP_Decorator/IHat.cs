namespace PP_Decorator;

/// <summary>
/// Base interface
/// </summary>
public interface IHat
{
    public string Name { get; }
    public int Price { get; }
    public string Description { get; }
    public bool IsPremium { get; }
}