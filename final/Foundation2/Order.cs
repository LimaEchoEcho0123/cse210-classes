public class Order
{
    private string _Product;
    private string _Customer;
    private string _Address;
    private float _Price;

    private float _TotalPrice = 0;



    public List<string> prices = new List<string>();
    public Order(string Product, string Customer, string Address)
    {
        _Product = Product;
        _Customer = Customer;
        _Address = Address;
    }


    public Order(string Product, string Customer, string Address, int Price)
    {
        _Product = Product;
        _Customer = Customer;
        _Address = Address;
        _Price = Price;
    }

        public int TotalPrice(int totalprice)
    {
        foreach (var price in prices)
        {
            totalprice.(ToString) += price;

        };
        return totalprice;
    }

    public string WholeOrder(int totalprice)
    {
        string WholeOrder = $"{_Product}, {_Customer}, {_Address}, {TotalPrice(totalprice)}";
        return WholeOrder;
    }
}