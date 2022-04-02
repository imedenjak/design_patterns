namespace FactoryMethod;

/// <summary>
/// Product
/// </summary>
public abstract class DiscountService
{
    public abstract int DiscountPercentage { get; }
    
    public override string ToString() => GetType().Name;
}

/// <summary>
/// Concrete Product
/// </summary>
public class CountryDiscountService : DiscountService
{
    private readonly string _countryCode;

    public CountryDiscountService(string countryCode)
    {
        _countryCode = countryCode;
    }

    public override int DiscountPercentage
    {
        get
        {
            switch (_countryCode)
            {
                case "HR":
                    return 20;
                default:
                    return 10;
            }
        }
    }
}

/// <summary>
/// Concrete Product
/// </summary>
public class CodeDiscountService : DiscountService
{
    private readonly Guid _code;

    public CodeDiscountService(Guid code)
    {
        _code = code;
    }

    public override int DiscountPercentage => 15;
}


// ==============================
// FACTORY
// ==============================

/// <summary>
/// Creator
/// </summary>
public abstract class DiscountFactory
{
    public abstract DiscountService CreateDiscountService();
}

/// <summary>
/// Concrete Creator
/// </summary>
public class CodeDiscountFactory: DiscountFactory
{
    private readonly Guid _code;

    public CodeDiscountFactory(Guid code)
    {
        _code = code;
    }
    public override DiscountService CreateDiscountService()
    {
        return new CodeDiscountService(_code);
    }
}

/// <summary>
/// Concrete Creator
/// </summary>
public class CountryDiscountFactory : DiscountFactory
{
    private readonly string _countryCode;

    public CountryDiscountFactory(string countryCode)
    {
        _countryCode = countryCode;
    }

    public override DiscountService CreateDiscountService()
    {
        return new CountryDiscountService(_countryCode);
    }
}