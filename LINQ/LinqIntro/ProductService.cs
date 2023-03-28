namespace LinqIntro;

public class ProductService
{
    private List<Product> products;

    public ProductService()
    {
        products = new()
        {
            new() { Id = 1, Name = "Bicycle", Description = "Sportive", Price = 3000, Stock = 250},
            new() { Id = 2, Name = "T-Shirt", Description = "Cloths", Price = 300, Stock = 1250},
            new() { Id = 3, Name = "Short", Description = "Sportive-Cloths", Price = 320, Stock = 250},
            new() { Id = 4, Name = "Camping-Bicycle", Description = "Camping", Price = 13000, Stock = 250},
        };
    }

    public List<Product> GetProducts()
    {
        return products;
    }
}