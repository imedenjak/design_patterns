namespace PP_Decorator;

/// <summary>
/// Base interface
/// </summary>
public interface IHat
{
    string Name { get; }
    int Price { get; }
    string Description { get; }
    bool IsPremium { get; }
}