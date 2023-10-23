public class Order
{
    private string _Product;
    private string _Customer;
    private string _Address;
    public Order(string Product, string Customer, string Address)
    {
        _Product = Product;
        _Customer = Customer;
        _Address = Address;
    }

    public string WholeOrder()
    {
        string WholeOrder = $"{_Product}, {_Customer}, {_Address}";
        return WholeOrder;
    }
}