using Ex04.Menus.Interfaces.MenuItems;

namespace Ex04.Menus.Interfaces
{

    // Manages the menu system and handles user navigation.
    public class MainMenu
    {
        private readonly MenuSubMenuItem r_RootMenu;

        public MainMenu(string i_Title)
        {
            r_RootMenu = new MenuSubMenuItem(i_Title);
        }

        public MenuSubMenuItem RootMenu
        {
            get
            {
                return r_RootMenu;
            }
        }

        public void Show()
        {
        }
    }
}