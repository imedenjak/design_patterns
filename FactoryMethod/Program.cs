using FactoryMethod;

Console.WriteLine("Hello, World!");

var factories = new List<DiscountFactory>
{
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("HR")
};

foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    
    Console.WriteLine($"Percentage {discountService.DiscountPercentage}, " +
                      $"coming from {discountService}");
}

Console.ReadLine();

var newFactories = new List<IDiscountFactory>
{ 
    new NewCodeDiscountFactory(Guid.NewGuid()),
    new NewCountryDiscountFactory("HR")
};

foreach (var newFactory in newFactories)
{
    var newDiscountService = newFactory.CreateDiscountService();
    Console.WriteLine($"Percentage {newDiscountService.DiscountPercentage}, " +
                      $"coming from {newDiscountService.GetType().Name}");
}

Console.ReadKey();