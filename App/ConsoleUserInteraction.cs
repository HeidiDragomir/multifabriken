
namespace Multifabriken.App
{
    public class ConsoleUserInteraction
    {

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public bool IsUserInputNullOrEmpty(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                ShowMessage("Ditt val är null eller empty.");
                Console.ResetColor();
                return true;
            }
            return false;
        }

        public bool IsUserInputValid(string input, out int number)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                ShowMessage("Ditt val är null eller empty.");
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
            ShowMessage("Nej, du måste välja en siffra. Försök igen!");
            Console.ResetColor();
            return false;

        }


        public void Exit()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
