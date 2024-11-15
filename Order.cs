

using Multifabriken.App;
using Multifabriken.Products;

namespace Multifabriken
{
    public class Order
    {
        private List<Product> _products = new List<Product>();

        ConsoleUserInteraction userInteraction = new ConsoleUserInteraction();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void SeeAllProducts()
        {
            if (_products.Count > 0)
            {
                userInteraction.ShowMessage("Din order:\n");
                foreach (Product product in _products)
                {
                    product.DisplayInfo();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                userInteraction.ShowMessage("Det finns inga beställda produkter.\n");
                Console.ResetColor();
            }

        }

        
    }
}
