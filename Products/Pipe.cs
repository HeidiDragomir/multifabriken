

namespace Multifabriken.Products
{
    public class Pipe : Product
    {
        public override string Name => "Rör";

        public int Diameter { get; set; }

        public int Length { get; set; }

        public Pipe(int diameter, int length)
        {
            Diameter = diameter;
            Length = length;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Rör info:");
            Console.WriteLine(@$"
Diameter: {Diameter}
Längd: {Length}
            ");

        }
    }
}
