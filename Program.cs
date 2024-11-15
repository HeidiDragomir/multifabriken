
using Multifabriken.Products;
using Multifabriken;
using Multifabriken.App;

Order order = new Order();

ConsoleUserInteraction userInteraction = new ConsoleUserInteraction();

userInteraction.ShowMessage("Välkommen, kunden!\n");

bool run = true;

while (run)
{
    userInteraction.ShowMessage("Vad vill du göra?");
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
                userInteraction.ShowMessage("b. Godis.");
                userInteraction.ShowMessage("c. Rör.");
                userInteraction.ShowMessage("d. Havremjölk.");
                userInteraction.ShowMessage("x. Ingenting. Tillbaka till meny.");

                string choiceProduct = Console.ReadLine();

                Console.Clear();

                if (string.IsNullOrEmpty(choiceProduct))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    userInteraction.ShowMessage("Ditt val är null eller empty.\n");
                    Console.ResetColor();
                    continue;
                }

                switch (choiceProduct)
                {
                    case "A":
                    case "a":

                        Product orderedCar = order.GetProductDetails("car", userInteraction);

                        Console.Clear();

                        order.AddProduct(orderedCar);

                        orderedCar.DisplayInfo();

                        break;

                    case "B":
                    case "b":

                        Product orderedSweets = order.GetProductDetails("sweets", userInteraction);

                        Console.Clear();

                        order.AddProduct(orderedSweets);

                        orderedSweets.DisplayInfo();

                        break;

                    case "C":
                    case "c":

                        Product orderedPipe = order.GetProductDetails("pipe", userInteraction);

                        Console.Clear();

                        order.AddProduct(orderedPipe);

                        orderedPipe.DisplayInfo();

                        break;

                    case "D":
                    case "d":

                        Product orderedOatMilk = order.GetProductDetails("oatmilk", userInteraction);

                        Console.Clear();

                        order.AddProduct(orderedOatMilk);

                        orderedOatMilk.DisplayInfo();

                        break;

                    case "X":
                    case "x":
                        userInteraction.ShowMessage("Tillbaka till meny.\n");
                        run2 = false;
                        break;

                    default:
                        userInteraction.ShowMessage("Försök igen!\n");
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
            userInteraction.ShowMessage("Ogiltigt val. Försök igen!");
            break;
    }
}




