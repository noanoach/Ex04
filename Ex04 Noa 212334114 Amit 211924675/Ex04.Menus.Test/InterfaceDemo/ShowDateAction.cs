using System;
using Ex04.Menus.Interfaces.Interfaces;

namespace Ex04.Menus.Test.InterfaceDemo
{
    // Displays the current date when selected from the interfaces menu.
    public class ShowDateAction : IMenuItemSelectedListener
    {
        public void MenuItemSelected()
        {
            Console.WriteLine("> Current Date is {0}", DateTime.Now.ToShortDateString());
        }
    }
}