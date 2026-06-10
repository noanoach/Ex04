using System.Collections.Generic;

namespace Ex04.Menus.Interfaces.MenuItems
{

    // Represents a menu item that contains child menu items.
    public class MenuSubMenuItem : MenuItem
    {
        private readonly List<MenuItem> r_MenuItems;

        public List<MenuItem> MenuItems
        {
            get
            {
                return r_MenuItems;
            }
        }

        public MenuSubMenuItem(string i_Title)
            : base(i_Title)
        {
            r_MenuItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_MenuItems.Add(i_MenuItem);
        }
    }
}