namespace PP_Decorator;

public class PremiumHat : IHat
{
    public PremiumHat(string name)
    {
        Name = name;
    }
    public string Name { get; }

    public int Price => 3000;

    public string Description => Name;

    public bool IsPremium => true;
}