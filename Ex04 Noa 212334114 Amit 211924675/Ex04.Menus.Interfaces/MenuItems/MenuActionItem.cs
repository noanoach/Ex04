using Ex04.Menus.Interfaces.Interfaces;

namespace Ex04.Menus.Interfaces.MenuItems
{

    // Represents a leaf menu item that executes an action when selected.
    public class MenuActionItem : MenuItem
    {
        private readonly IMenuItemSelectedListener r_MenuItemSelectedListener;

        public MenuActionItem(string i_Title, IMenuItemSelectedListener i_MenuItemSelectedListener)
            : base(i_Title)
        {
            r_MenuItemSelectedListener = i_MenuItemSelectedListener;
        }

        internal void Select()
        {
            r_MenuItemSelectedListener.MenuItemSelected();
        }
    }
}