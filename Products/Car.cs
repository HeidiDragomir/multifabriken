

namespace Multifabriken.Products
{
    public class Car : Product
    {
        public string Name => "Bil";

        public string RegistrationNumber {  get; set; }

        public string Color { get; set; }

        public string Brand { get; set; }


        public string AddChoice(string choice)
        {
            return choice;
        }
    }
}
