

public class Product
{
    private string _Product;

    private int _Price;

    public Product(string Product, int Price)
    {
        _Product = Product;
        _Price = Price;
    }
    public void setProduct(string Product)
    {
        _Product = Product;
    }

    public string getProduct()
    {
        return $"{_Product}";
    }

    public void setPrice(int Price)
    {
        _Price = Price;
    }
    public string getPrice()
    {
        return $"{_Price}";
    }

    public string ProductDisplay()
    {
        string ProductDisplay = $"{_Product}, {_Price}";
        return ProductDisplay;
    }

}