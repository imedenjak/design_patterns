namespace PP_Decorator;

/// <summary>
/// Concrete Component 2
/// </summary>
public class StandardHat : IHat
{
    public StandardHat(string name)
    {
        Name = name;
    }
    public string Name { get; }

    public int Price => 2000;

    public string Description => $"Standard hat named: {Name}";

    public bool IsPremium => false;
}