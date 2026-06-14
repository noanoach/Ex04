using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    public class MenuSubMenuItem : MenuItem
    {
        private readonly List<MenuItem> r_MenuItems;

        public MenuSubMenuItem(string i_Title)
            : base(i_Title)
        {
            r_MenuItems = new List<MenuItem>();
        }

        internal List<MenuItem> MenuItems
        {
            get
            {
                return r_MenuItems;
            }
        }

        public void AddItem(MenuItem i_MenuItem)
        {
            r_MenuItems.Add(i_MenuItem);
        }

        internal override void Select()
        {
        }
    }
}