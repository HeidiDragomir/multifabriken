
using Multifabriken.Products;

namespace Multifabriken.App
{
    public class ConsoleUserInteraction
    {

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }


        public bool IsUserInputValid(string input, out int number)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                ShowMessage("Ditt val är null eller empty.\n");
                number = 0;
                Console.ResetColor();
                return false;
            }

            bool isParsingSuccesfulInput = int.TryParse(input, out number);

            if (isParsingSuccesfulInput)
            {
                return true;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            ShowMessage("Nej, du måste välja en siffra. Försök igen!\n");
            Console.ResetColor();
            return false;

        }

        public Product GetProductDetails(string productType)
        {
            // Create a dictionary collection for all details
            Dictionary<string, string> details = new Dictionary<string, string>();

            // for every product type add in Dictionary its properties and corresponding message
            switch (productType.ToLower())
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
                    ShowMessage("Ogiltig produkttyp.\n");
                    break;
            }


            // Create a dictionary collection for all user inputs
            Dictionary<string, string> inputs = new Dictionary<string, string>();

            foreach (var detail in details)
            {
                string input;

                do
                {
                    ShowMessage(detail.Value);
                    input = Console.ReadLine();

                    // Validate the input for null or empty
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        ShowMessage("Ditt val är null eller empty.\n");
                        Console.ResetColor();
                    }
                    else if (detail.Key == "quantity" && !int.TryParse(input, out _))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        ShowMessage("Antalet måste vara en siffra. Försök igen!\n");
                        Console.ResetColor();
                        input = null; // Reset for re-entry
                    }
                    else if (detail.Key == "diameter" && !int.TryParse(input, out _))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        ShowMessage("Diameter måste vara en siffra. Försök igen!\n");
                        Console.ResetColor();
                        input = null; // Reset for re-entry
                    }
                    else if (detail.Key == "length" && !int.TryParse(input, out _))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        ShowMessage("Längd måste vara en siffra. Försök igen!\n");
                        Console.ResetColor();
                        input = null; // Reset for re-entry
                    }
                    else if (detail.Key == "liter" && !int.TryParse(input, out _))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        ShowMessage("Litermängd måste vara en siffra. Försök igen!\n");
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

        public void Exit()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
