using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CodefirstdemoProg
{
    class Program
    {
        static void Main(string[] args)
        {
             ProductDBContext Context = new ProductDBContext();

             LinqToEntity();
        }

        public static void LinqToEntity()
        {
            ProductDBContext context = new ProductDBContext();
            var EconProducts = from product in context.Products
                               where product.Price < 50
                               select product;

            foreach (var product in EconProducts)
            {
                Console.WriteLine("ProductID:{0},Name:{1},Price:{2}", product.ProductID, product.Name,product.Price);
            }
        }
    }

    public class ProductDBContext : DbContext
    {
        public ProductDBContext():
            base("name=ProductDBContext")
        {}

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Quantity { get; set; }

        public int CategoryID{ get; set; }
    }

    public class Category
    {
        public int CategoryID { get; set; }

        public string Name { get; set; }
    }
}
