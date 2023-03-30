namespace LinqIntro;

public class ProductService
{
    private List<Product> products;
    private List<Category> categories;

    public ProductService()
    {
        categories = new()
        {
            new(){Id = 1, Name = "Camping"},
            new(){Id = 2, Name = "Sport"},
            new(){Id = 3, Name = "Clothing"},
            new(){Id = 4, Name = "Fishing"},
        };

        products = new()
        {
            new() { Id = 1, Name = "Bicycle", Description = "Sportive", Price = 3000, Stock = 250, Category = categories[1]},
            new() { Id = 2, Name = "Bicycle-City", Description = "City", Price = 300, Stock = 350, Category = categories[1]},
            new() { Id = 3, Name = "T-Shirt", Description = "Cloths", Price = 300, Stock = 1250, Category = categories[2]},
            new() { Id = 4, Name = "Short", Description = "Sportive-Cloths", Price = 200, Stock = 2250, Category = categories[2]},
            new() { Id = 5, Name = "Hat", Description = "Sportive-Cloths", Price = 200, Stock = 4450, Category = categories[2]},
            new() { Id = 6, Name = "Camping-Bicycle", Description = "Camping", Price = 13000, Stock = 50, Category = categories[0]},
            new() { Id = 7, Name = "Camping-Shoe", Description = "Camping", Price = 999, Stock = 2250, Category = categories[0]},
            new() { Id = 8, Name = "Fishing Rod", Description = "Fishing", Price = 14999, Stock = 10, Category = categories[3]},
        };
    }

    public List<Product> GetProducts()
    {
        return products;
    }
    public List<Category> GetCategories()
    {
        return categories;
    }
}