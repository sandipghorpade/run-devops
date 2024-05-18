using MongoDB.Driver;
using Shopping.API.Models;

namespace Shopping.API.Data
{
    public class ProductContext
    {
        IConfiguration _configuration;
        public IMongoCollection<Product> Products { get; }

        public ProductContext(IConfiguration configuration)
        {
            _configuration = configuration;
            var client = new MongoClient(_configuration["DatabaseSettings:ConnectionString"]);
            var database = client.GetDatabase(_configuration["DatabaseSettings:DatabaseName"]);
            Products  = database.GetCollection<Product>(_configuration["DatabaseSettings:CollectionName"]);
            SeedData(Products);
        }

        private static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool exitProduct = productCollection.Find(p => true).Any();
            if (!exitProduct)
            {
                productCollection.InsertManyAsync(GetConfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetConfiguredProducts()
        {

            return new List<Product>()
            {
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
}
