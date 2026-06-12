using System;
using Ex04.Menus.Interfaces.Interfaces;

namespace Ex04.Menus.Test.InterfaceDemo
{
    // Counts uppercase letters in text entered by the user.
    public class CountCapitalsAction : IMenuItemSelectedListener
    {
        public void MenuItemSelected()
        {
            string userText = Console.ReadLine();
            int uppercaseLettersCount = countUppercaseLetters(userText);

            Console.WriteLine("> There are {0} uppercase letters in your text", uppercaseLettersCount);
        }

        private int countUppercaseLetters(string i_Text)
        {
            int uppercaseLettersCount = 0;

            foreach (char currentChar in i_Text)
            {
                if (char.IsUpper(currentChar))
                {
                    ++uppercaseLettersCount;
                }
            }

            return uppercaseLettersCount;
        }
    }
}