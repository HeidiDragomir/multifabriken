
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
                ShowMessage("Ditt val är null eller empty.");
                number = 0;
                return false;
            }

            bool isParsingSuccesfulInput = int.TryParse(input, out number);

            if (isParsingSuccesfulInput )
            {
                return true;
            }

            ShowMessage("Nej, du måste välja en siffra. Försök igen!");
            return false;

        }
            

        public void Exit()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
