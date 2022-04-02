namespace AbstractFactory;

/// <summary>
/// AbstractFactory
/// </summary>
public interface IShoppingCartPurchaseFactory
{
    IDiscountService CreateDiscountService();
    IShippingCostsService CreateShippingCostsService();
}

/// <summary>
/// AbstractProduct
/// </summary>
public interface IShippingCostsService
{
    decimal ShippingCosts { get; }
}

/// <summary>
/// ConcreteProduct
/// </summary>
public class CroatianShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 5;
}

/// <summary>
/// ConcreteProduct
/// </summary>
public class FranceShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 10;
}


/// <summary>
/// AbstractProduct
/// </summary>
public interface IDiscountService
{
    int DiscountPercentage { get; }
}

/// <summary>
/// ConcreteProduct
/// </summary>
public class CroatianDiscountService : IDiscountService
{
    public int DiscountPercentage => 10;
}

/// <summary>
/// ConcreteProduct
/// </summary>
public class FranceDiscountService : IDiscountService
{
    public int DiscountPercentage => 5;
}

/// <summary>
/// ConcreteFactory
/// </summary>
public class CroatianShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new CroatianDiscountService();
    }

    public IShippingCostsService CreateShippingCostsService()
    {
        return new CroatianShippingCostsService();
    }
}

/// <summary>
/// ConcreteFactory
/// </summary>
public class FranceShoppingCardPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new FranceDiscountService();
    }

    public IShippingCostsService CreateShippingCostsService()
    {
        return new FranceShippingCostsService();
    }
}

/// <summary>
/// Client class
/// </summary>
public class ShoppingCart
{
    private readonly IDiscountService _discountService;
    private readonly IShippingCostsService _shippingCostsService;

    private readonly int _orderCosts;

    public ShoppingCart(IShoppingCartPurchaseFactory factory)
    {
        _discountService = factory.CreateDiscountService();
        _shippingCostsService = factory.CreateShippingCostsService();

        _orderCosts = 200;
    }

    public void CalculateCosts()
    {
        Console.WriteLine($"Total costs = {_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts}");
    }
}