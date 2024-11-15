

namespace Multifabriken.Products
{
    public class OatMilk : Product
    {

        public override string Name => "Havremjölk";

        public string Fat { get; set; }

        public int Liter { get; set; }

        public OatMilk(string fat, int liter)
        {
            Fat = fat;
            Liter = liter;
        }

        public override void DisplayInfo()
        {
            DisplayHeader();
            Console.WriteLine(@$"Fetthalt: {Fat}
Litermängd: {Liter}
            ");

        }
    }
}
