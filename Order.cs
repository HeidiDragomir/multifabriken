

using Multifabriken.Products;

namespace Multifabriken
{
    public class Order
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void SeeAllProducts()
        {
            foreach (Product product in _products)
            {
                product.DisplayInfo();
            }
        }
    }
}
