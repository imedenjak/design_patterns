namespace PP_Decorator;

public class StandardHat : IHat
{
    public StandardHat(string name)
    {
        Name = name;
    }
    public string Name { get; }

    public int Price => 2000;

    public string Description => Name;

    public bool IsPremium => false;
}