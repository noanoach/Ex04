using System;
using Ex04.Menus.Interfaces.Interfaces;

namespace Ex04.Menus.Test.InterfaceDemo
{
    // Displays the application version.
    public class ShowVersionAction : IMenuItemSelectedListener
    {
        public void MenuItemSelected()
        {
            Console.WriteLine("App Version: 26.2.4.7310");
        }
    }
}