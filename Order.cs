

using Multifabriken.App;
using Multifabriken.Products;

namespace Multifabriken
{
    public class Order
    {
        private List<Product> _products = new List<Product>();

        ConsoleUserInteraction userInteraction = new ConsoleUserInteraction();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void SeeAllProducts()
        {
            if (_products.Count > 0)
            {
                userInteraction.ShowMessage("Din order:\n");
                foreach (Product product in _products)
                {
                    product.DisplayInfo();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                userInteraction.ShowMessage("Det finns inga beställda produkter.\n");
                Console.ResetColor();
            }

        }

        public Product GetProductDetails(string productType, ConsoleUserInteraction userInteraction)
        {
            // Create a dictionary collection for all details
            Dictionary<string, string> details = new Dictionary<string, string>();

            // for every product type add in Dictionary its properties and corresponding message
            switch(productType.ToLower())
            {
                case "car":
                    details.Add("registreringsnummer", "Skriv registreringsnummer: ");
                    details.Add("color", "Skriv färg: ");
                    details.Add("brand", "Skriv bilmärke: ");
                    break;

                case "sweets":
                    details.Add("flavour", "Skriv smak: ");
                    details.Add("quantity", "Skriv antal: ");
                    break;

                case "pipe":
                    details.Add("diameter", "Skriv diameter: ");
                    details.Add("length", "Skriv längd: ");
                    break;

                case "oatmilk":
                    details.Add("fat", "Skriv fetthalt: ");
                    details.Add("liter", "Skriv litermängd: ");
                    break;

                default:
                    userInteraction.ShowMessage("Ogiltig produkttyp.\n");
                    break;
            }


            // Create a dictionary collection for all user inputs
            Dictionary<string, string> inputs = new Dictionary<string, string>();

            foreach(var detail in details)
            {
                string input;

                do
                {
                    userInteraction.ShowMessage(detail.Value);
                    input = Console.ReadLine();

                    // Validate the input for null or empty
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        userInteraction.ShowMessage("Ditt val är null eller empty.\n");
                        Console.ResetColor();
                    }
                    else if (detail.Key == "quantity" && !int.TryParse(input, out _))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        userInteraction.ShowMessage("Antalet måste vara en siffra. Försök igen!\n");
                        Console.ResetColor();
                        input = null; // Reset for re-entry
                    }
                    else if (detail.Key == "diameter" && !int.TryParse(input, out _))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        userInteraction.ShowMessage("Diameter måste vara en siffra. Försök igen!\n");
                        Console.ResetColor();
                        input = null; // Reset for re-entry
                    }
                    else if (detail.Key == "length" && !int.TryParse(input, out _))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        userInteraction.ShowMessage("Längd måste vara en siffra. Försök igen!\n");
                        Console.ResetColor();
                        input = null; // Reset for re-entry
                    }
                    else if (detail.Key == "liter" && !int.TryParse(input, out _))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        userInteraction.ShowMessage("Litermängd måste vara en siffra. Försök igen!\n");
                        Console.ResetColor();
                        input = null; // Reset for re-entry
                    }
                } while (string.IsNullOrEmpty(input));

                inputs[detail.Key] = input;
            }

            // Return the appropriate product based on product type
            return productType.ToLower() switch
            {
                "car" => new Car(inputs["registreringsnummer"], inputs["color"], inputs["brand"]),
                "sweets" => new Sweets(inputs["flavour"], int.Parse(inputs["quantity"])),
                "pipe" => new Pipe(int.Parse(inputs["diameter"]), int.Parse(inputs["length"])),
                "oatmilk" => new OatMilk(inputs["fat"], int.Parse(inputs["liter"]))
            };

        }
    }
}
