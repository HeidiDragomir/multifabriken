namespace Multifabriken.Products
{
    public class Product
    {
        public virtual string Name { get; }

        protected void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Name}:");
            Console.ResetColor();
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Produkt info:");
        }
    }
}
