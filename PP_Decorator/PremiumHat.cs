namespace PP_Decorator;

/// <summary>
/// Concrete Component 1 - specific thing - IS a thing
/// </summary>
public class PremiumHat : IHat
{
    public PremiumHat(string name)
    {
        Name = name;
    }
    public string Name { get; }

    public int Price => 3000;

    public string Description => $"Premium hat named: {Name}";

    public bool IsPremium => true;
}