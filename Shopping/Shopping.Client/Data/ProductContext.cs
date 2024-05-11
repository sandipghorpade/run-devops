using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product> {
        new Product()
        { 
            Name="Iphone X",
            Description="IPhone X is beautiful",
            ImageFile="product-1.png",
            Price=950.00m,
            Category="Smart Phone"
        },
        new Product()
        {
            Name="Iphone XIV",
            Description="IPhone XIV is beautiful",
            ImageFile="product-1.png",
            Price=1500.00m,
            Category="Smart Phone"
        },
        new Product()
        {
            Name="Samsung Galaxy S23",
            Description="Samsung Galaxy S23 is beautiful",
            ImageFile="product-1.png",
            Price=1200.00m,
            Category="Smart Phone"
        }

      };
    }
}
