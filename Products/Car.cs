

namespace Multifabriken.Products
{
    public class Car : Product
    {
        public string Name => "Bil";

        public int RegistrationNumber {  get; set; }

        public string Color { get; set; }

        public string Brand { get; set; }

    }
}
