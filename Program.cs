
using Multifabriken.Products;
using Multifabriken;
using Multifabriken.App;

Order order = new Order();

ConsoleUserInteraction userInteraction = new ConsoleUserInteraction();

userInteraction.ShowMessage("Välkommen, kunden!");

bool run = true;

while (run)
{

    userInteraction.ShowMessage("\nVad vill du göra?");
    userInteraction.ShowMessage("1. Beställa produkt.");
    userInteraction.ShowMessage("2. Se alla beställda produkter.");
    userInteraction.ShowMessage("3. Avsulta programmet.");

    string choiceMainMenu = Console.ReadLine();

    Console.Clear();

    // Check if the user input is valid
    // If input is invalid, go back to the start of the loop
    if (!userInteraction.IsUserInputValid(choiceMainMenu, out int number))
    {
        continue;
    }


    switch (number)
    {
        case 1:

            bool run2 = true;

            while (run2)
            {
                userInteraction.ShowMessage("Vad vill du beställa?");
                userInteraction.ShowMessage("a. Bil.");
                userInteraction.ShowMessage("b. Goodis.");
                userInteraction.ShowMessage("c. Rör.");
                userInteraction.ShowMessage("d. Havremjölk.");
                userInteraction.ShowMessage("x. Ingenting. Tillbaka till meny.");

                string choiceProduct = Console.ReadLine();

                Console.Clear();

                //if (string.IsNullOrEmpty(choiceProduct))
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    userInteraction.ShowMessage("Ditt val är null eller empty.");
                //    Console.ResetColor();
                //    continue;
                //}
                userInteraction.IsUserInputNullOrEmpty(choiceProduct);

                switch (choiceProduct)
                {
                    case "A":
                    case "a":

                        bool run3 = true;

                        while (run3)
                        {

                            string registrationNumber;
                            do
                            {
                                userInteraction.ShowMessage("Skriv registreringsnummer: ");
                                registrationNumber = Console.ReadLine();

                                userInteraction.IsUserInputNullOrEmpty(registrationNumber);

                            } while (string.IsNullOrEmpty(registrationNumber));

                            string color;
                            do
                            {
                                userInteraction.ShowMessage("Skriv färg: ");
                                color = Console.ReadLine();

                                userInteraction.IsUserInputNullOrEmpty(color);
                            } while (string.IsNullOrEmpty(color));

                            string brand;
                            do
                            {
                                userInteraction.ShowMessage("Skriv bilmärke: ");
                                brand = Console.ReadLine();

                                userInteraction.IsUserInputNullOrEmpty(brand);
                            } while (string.IsNullOrEmpty(brand));


                            // Create Car object with the provided info
                            Product orderedCar = new Car(registrationNumber, color, brand);

                            Console.Clear();

                            order.AddProduct(orderedCar);

                            orderedCar.DisplayInfo();

                            run3 = false;
                        }

                        break;

                    case "B":
                    case "b":

                        bool run4 = true;

                        while (run4)
                        {

                            string flavour;
                            int num4;
                            do
                            {
                                userInteraction.ShowMessage("Skriv smak: ");
                                flavour = Console.ReadLine();

                                userInteraction.IsUserInputNullOrEmpty(flavour);

                            } while (string.IsNullOrEmpty(flavour));

                            string quantity;
                            do
                            {
                                userInteraction.ShowMessage("Skriv antal: ");
                                quantity = Console.ReadLine();

                                userInteraction.IsUserInputValid(quantity, out num4);
                            } while (string.IsNullOrEmpty(quantity));


                            Product orderedSweets = new Sweets(flavour, num4);

                            Console.Clear();

                            order.AddProduct(orderedSweets);

                            orderedSweets.DisplayInfo();

                            run4 = false;
                        }
                        break;

                    case "C":
                    case "c":

                        //userInteraction.ShowMessage("Skriv diamter: ");

                        //string diameter = Console.ReadLine();

                        //userInteraction.ShowMessage("Skriv längd: ");

                        //string length = Console.ReadLine();

                        //userInteraction.IsUserInputValid(diameter, out int num2);
                        //userInteraction.IsUserInputValid(length, out int num3);

                        //Product orderedPipe = new Pipe(diameter, length);

                        //Console.Clear();

                        //order.AddProduct(orderedSweets);

                        //orderedSweets.DisplayInfo();

                        break;

                    case "D":
                    case "d":
                        userInteraction.ShowMessage("Du har beställt havremjöl.");
                        break;

                    case "X":
                    case "x":
                        userInteraction.ShowMessage("Back to the main menu.");
                        run2 = false;
                        break;

                    default:
                        userInteraction.ShowMessage("Försök igen!");
                        break;

                }

            }


            break;

        case 2:

            order.SeeAllProducts();

            break;

        case 3:
            userInteraction.ShowMessage("Program avslutas.");
            run = false;
            userInteraction.Exit();
            break;

        default:
            userInteraction.ShowMessage("Försök igen!");
            break;
    }
}




