public class Address
{
    private string _Address;

    public Address(string Address)
    {
        _Address = Address;
    }
    public void setAddress(string Address)
    {
        _Address = Address;
    }
    public string getAddress()
    {
        return $"{_Address}";
    }
}