namespace Multifabriken.Products
{
    public class Product
    {
        public virtual string Name { get; }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Produkt info:");
        }
    }
}
