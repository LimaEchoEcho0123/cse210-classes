public class Customer
{   
    
    private string _Customer;

    Address _Address;

    public Customer(string Customer)
    {
        _Customer = Customer;
    }
    public string GetCustomer()
    {
        return _Customer;
    }
    public void CustomerDisplay()
    {
        Console.WriteLine($"{_Customer}, {_Address}");
    }
}