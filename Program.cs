
using Multifabriken.Products;
using Multifabriken;
using Multifabriken.App;

Console.WriteLine("Välkommen, kunden!");

Order order = new Order();


ConsoleUserInteraction userInteraction = new ConsoleUserInteraction();

bool run = true;

while (run)
{
    userInteraction.ShowMessage("Vad vill du göra?");

    userInteraction.ShowMessage("1. Beställa produkt.");
    userInteraction.ShowMessage("2. Se alla beställda produkter.");
    userInteraction.ShowMessage("3. Avsulta programmet.");

    string choiceMainMenu = Console.ReadLine();
    //int number;

    //bool isParsingSuccesfulInput = int.TryParse(choiceMainMenu, out int number);


    //if (String.IsNullOrEmpty(choiceMainMenu))
    //{
    //    userInteraction.ShowMessage("Ditt val är null eller empty.");
    //    continue;
    //}
    //else if (!isParsingSuccesfulInput)
    //{
    //    userInteraction.ShowMessage("Nej, du måste välja en siffra. Försök igen!");
    //    continue;
    //}
    //else
    //{
    //    userInteraction.ShowMessage($"Du har valt {number}.");
    //}

    if (!userInteraction.IsUserInputValid(choiceMainMenu, out int number))
    {
        continue;
    }

    Console.Clear();

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

                switch (choiceProduct)
                {
                    case "a":

                        // Ask user for car details
                        userInteraction.ShowMessage("Skriv registreringsnummer: ");
                        string registrationNumber = Console.ReadLine();

                        userInteraction.ShowMessage("Skriv färg: ");
                        string color = Console.ReadLine();

                        userInteraction.ShowMessage("Skriv bilmärke: ");
                        string brand = Console.ReadLine();

                        // Create Car object with the provided info
                        Product orderedCar = new Car(registrationNumber, color, brand);

                        Console.Clear();

                        order.AddProduct(orderedCar);

                        orderedCar.DisplayInfo();

                        break;

                    case "b":
                        // Ask user for car details
                        userInteraction.ShowMessage("Skriv smak: ");
                        string flavour = Console.ReadLine();

                        userInteraction.ShowMessage("Skriv antal: ");
                        string quantity = Console.ReadLine();

                        userInteraction.IsUserInputValid(quantity, out int num);

                        // Create Car object with the provided info
                        Product orderedSweets = new Sweets(flavour, num);

                        //Console.Clear();

                        order.AddProduct(orderedSweets);

                        orderedSweets.DisplayInfo();

                        break;

                    case "c":
                        userInteraction.ShowMessage("Du har beställt en rör.");
                        break;

                    case "d":
                        userInteraction.ShowMessage("Du har beställt havremjöl.");
                        break;

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
            userInteraction.ShowMessage("Din order:");

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




