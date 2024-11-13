
using Multifabriken.Products;

var car = new Car();


Console.WriteLine("Välkommen, kunden!");



bool run = true;

while (run)
{
    Console.WriteLine("Vad vill du göra?");

    Console.WriteLine("1. Beställa produkt.");
    Console.WriteLine("2. Se alla beställda produkter.");
    Console.WriteLine("3. Avsulta programmet.");

    string choiceMainMenu = Console.ReadLine();

    bool isParsingSuccesfulInput = int.TryParse(choiceMainMenu, out int number);

    if (String.IsNullOrEmpty(choiceMainMenu))
    {
        Console.WriteLine("Ditt val är null eller empty.");
    }
    else if (isParsingSuccesfulInput)
    {
        Console.WriteLine("Du har valt " + number + ".");
    }
    else
    {
        Console.WriteLine("Nej, du måste välja en siffra. Försök igen!");
    }

    switch (number)
    {
        case 1:

            bool run2 = true;

            while (run2)
            {
                Console.WriteLine("Vad vill du beställa?");
                Console.WriteLine("a. Bil.");
                Console.WriteLine("b. Goodis.");
                Console.WriteLine("c. Rör.");
                Console.WriteLine("d. Havremjölk.");
                Console.WriteLine("x. Return to previous menu.");

                string choiceProduct = Console.ReadLine();

                switch (choiceProduct)
                {
                    case "a":
                        Console.WriteLine("Du har valt en bil.");
                        Console.WriteLine("Skriv registreringsnummer:");

                        string input3 = Console.ReadLine();
                        

                        break;

                    case "b":
                        Console.WriteLine("Du har beställt goodis.");
                        break;

                    case "c":
                        Console.WriteLine("Du har beställt en rör.");
                        break;

                    case "d":
                        Console.WriteLine("Du har beställt havremjöl.");
                        break;

                    case "x":
                        Console.WriteLine("Back to the main menu.");
                        run2 = false;
                        break;

                    default:
                        Console.WriteLine("Försök igen!");
                        break;

                }

            }


            break;

        case 2:
            Console.WriteLine("Du kan se alla beställda produkter nu.");
            break;

        case 3:
            Console.WriteLine("Program avslutas.");
            run = false;
            break;

        default:
            Console.WriteLine("Försök igen!");
            break;
    }
}


Console.ReadKey();

