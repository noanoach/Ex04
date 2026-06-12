using Ex04.Menus.Interfaces;
using Ex04.Menus.Interfaces.MenuItems;
using Ex04.Menus.Test.InterfaceDemo;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            runInterfacesMenu();

            // TODO: Amit/partner - call the Events menu here after the Interfaces menu exits.
            // runEventsMenu();
        }

        private static void runInterfacesMenu()
        {
            MainMenu interfacesMainMenu = buildInterfacesMenu();

            interfacesMainMenu.Show();
        }

        private static MainMenu buildInterfacesMenu()
        {
            MainMenu interfacesMainMenu = new MainMenu("Interfaces Main Menu");

            MenuSubMenuItem showCurrentDateTimeSubMenu =
                new MenuSubMenuItem("Show Current Date/Time");

            MenuSubMenuItem versionAndCapitalsSubMenu =
                new MenuSubMenuItem("Version and Capitals");

            showCurrentDateTimeSubMenu.AddMenuItem(
                new MenuActionItem("Show Current Date", new ShowDateAction()));

            showCurrentDateTimeSubMenu.AddMenuItem(
                new MenuActionItem("Show Current Time", new ShowTimeAction()));

            versionAndCapitalsSubMenu.AddMenuItem(
                new MenuActionItem("Count Capitals", new CountCapitalsAction()));

            versionAndCapitalsSubMenu.AddMenuItem(
                new MenuActionItem("Show Version", new ShowVersionAction()));

            interfacesMainMenu.RootMenu.AddMenuItem(showCurrentDateTimeSubMenu);
            interfacesMainMenu.RootMenu.AddMenuItem(versionAndCapitalsSubMenu);

            return interfacesMainMenu;
        }
    }
}