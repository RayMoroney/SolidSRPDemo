using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // This Main method of the Program class just controls the flow of the application.

            StandardMessages.WelcomeMessage();

            IPersonModel user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplication();
        }
    }
}
