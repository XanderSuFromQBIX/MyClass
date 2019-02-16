using System;

namespace Q_BIX_Zach.TextAdventure
{
    public class PasswordPrompt
    {
        public void KeepAsking()
        {
            var secretAnswer = "superpassword";
            var currentAnswer = "";
            while (!currentAnswer.Equals(secretAnswer))
            {
                Console.WriteLine("Enter the secret password");
                currentAnswer = Console.ReadLine();
            }

            Console.WriteLine("Correct.");
        }
    }
}
