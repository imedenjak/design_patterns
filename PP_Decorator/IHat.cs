namespace PP_Decorator;

/// <summary>
/// Base interface - thing
/// </summary>
public interface IHat
{
    string Name { get; }
    int Price { get; }
    string Description { get; }
    bool IsPremium { get; }
}