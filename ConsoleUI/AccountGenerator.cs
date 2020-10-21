﻿using System;

namespace ConsoleUI
{
    public class AccountGenerator
    {
        public static void CreateAccount(IPersonModel user)
        {
            // Create a username for the person
            Console.WriteLine($"Your username is { user.FirstName.Substring(0, 1) }{ user.LastName }");
        }
    }
}
