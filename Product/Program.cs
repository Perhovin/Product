class Product
{
    public string Name;
    public int Price;
    public int Stock;


public Product(string name, int price, int stock)
{
    Name = name;
    Price = price;
    Stock = stock;

}
}
class Program
{
    static void Main()
    {
        Product product1 = new Product("Laptop", 1500, 10);
        Product product2 = new Product("Iphone", 1300, 20);
        
        Console.WriteLine($"Products: {product1.Name} - Price: {product1.Price} - Remained: {product1.Stock}");
        Console.WriteLine($"Products: {product2.Name} - Price: {product2.Price} - Remained: {product2.Stock}");
    }
}
