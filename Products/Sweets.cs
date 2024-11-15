

namespace Multifabriken.Products
{
    public class Sweets :Product
    {
        public override string Name => "Godis";

        public string Flavour {  get; set; }

        public int Quantity {  get; set; }

        public Sweets(string flavour, int quantity)
        {
            Flavour = flavour;
            Quantity = quantity;
        }

        public override void DisplayInfo()
        {
            DisplayHeader();
            Console.WriteLine(@$"Smak: {Flavour}
Antal: {Quantity}
            ");

        }
    }
}
