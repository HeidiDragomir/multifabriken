

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
            Console.WriteLine($"Oatmilk info:");
            Console.WriteLine(@$"
Fetthalt: {Fat}
Litermängd: {Liter}
            ");

        }
    }
}
