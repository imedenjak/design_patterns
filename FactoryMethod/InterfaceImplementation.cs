namespace FactoryMethod;

/// <summary>
/// Product
/// </summary>
public interface IDiscountService
{
    int DiscountPercentage { get; }
}


/// <summary>
/// Concrete Product
/// </summary>
public class NewCountryDiscountService : IDiscountService
{
    private readonly string _countryCode;

    public NewCountryDiscountService(string countryCode)
    {
        _countryCode = countryCode;
    }

    public int DiscountPercentage
    {
        get
        {
            switch (_countryCode)
            {
                case "HR":
                    return 25;
                default:
                    return 15;
            }
        }
    }
}

/// <summary>
/// Concrete Product
/// </summary>
public class NewCodeDiscountService : IDiscountService
{
    private readonly Guid _code;

    public NewCodeDiscountService(Guid code)
    {
        _code = code;
    }

    public int DiscountPercentage
    {
        get
        {
            if (_code != Guid.Empty)
            {
                return 18;
            }
            else
            {
                return 1;
            }
        }
    }
}

/// <summary>
/// Creator
/// </summary>
interface IDiscountFactory
{
    IDiscountService CreateDiscountService();
}

/// <summary>
/// Concrete Creator
/// </summary>
public class NewCountryDiscountFactory: IDiscountFactory
{
    private readonly string _countryCode;

    public NewCountryDiscountFactory(string countryCode)
    {
        _countryCode = countryCode;
    }
    public IDiscountService CreateDiscountService()
    {
        return new NewCountryDiscountService(_countryCode);
    }
}

/// <summary>
/// Concrete Creator
/// </summary>
public class NewCodeDiscountFactory: IDiscountFactory
{
    private readonly Guid _code;

    public NewCodeDiscountFactory(Guid code)
    {
        _code = code;
    }
    
    public IDiscountService CreateDiscountService()
    {
        return new NewCodeDiscountService(_code);
    }
}
