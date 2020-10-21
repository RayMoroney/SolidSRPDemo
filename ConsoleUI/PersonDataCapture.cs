using System;

namespace ConsoleUI
{
    public class PersonDataCapture
    {
        public static IPersonModel Capture()
        {
            // Ask for user information
            IPersonModel output = ClassInstanceGenerator.CreatePerson();

            Console.Write("What is your first name: ");
            output.FirstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
