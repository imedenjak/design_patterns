namespace PP_Composite;

public class MultipleOrder : IOrder
{
    private readonly List<IOrder> _orders = new();

    public string Description => 
        string.Join(Environment.NewLine, _orders.ConvertAll(order => order.Description));

    public int Price => 
        _orders.Sum(order => order.Price);

    public void Add(IOrder order)
    {
        _orders.Add(order);
    }
}