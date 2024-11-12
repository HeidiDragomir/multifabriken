

using Multifabriken.Products;

namespace Multifabriken
{
    public class Order
    {
        public List<Product> Products = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void SeeAllProducts()
        {
            Console.WriteLine("See products");
        }
    }
}
