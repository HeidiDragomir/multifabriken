

namespace Multifabriken.Products
{
    public class Car : Product
    {
        public override string Name => "Bil";

        public string RegistrationNumber { get; set; }

        public string Color { get; set; }

        public string Brand { get; set; }

        public Car(string registrationNumber, string color, string brand)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            Brand = brand;
        }


        public override void DisplayInfo()
        {
            DisplayHeader();

            Console.WriteLine(@$"Registreringsnummer: {RegistrationNumber}
Färg: {Color}
Bilmärke: {Brand}
            ");

        }
    }
}
