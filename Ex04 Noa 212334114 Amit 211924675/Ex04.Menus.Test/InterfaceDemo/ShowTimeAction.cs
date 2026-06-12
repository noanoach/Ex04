using System;
using Ex04.Menus.Interfaces.Interfaces;

namespace Ex04.Menus.Test.InterfaceDemo
{
    // Displays the current time when selected from the interfaces menu.
    public class ShowTimeAction : IMenuItemSelectedListener
    {
        public void MenuItemSelected()
        {
            Console.WriteLine("> Current Time is {0}", DateTime.Now.ToShortTimeString());
        }
    }
}