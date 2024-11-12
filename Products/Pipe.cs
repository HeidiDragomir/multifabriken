

namespace Multifabriken.Products
{
    public class Pipe : Product
    {
        public string Name => "Rör";

        public int Diameter { get; set; }

        public int Length { get; set; }
    }
}
