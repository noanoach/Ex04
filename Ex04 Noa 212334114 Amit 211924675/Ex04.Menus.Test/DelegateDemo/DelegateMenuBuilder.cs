using Ex04.Menus.Events;

namespace Ex04.Menus.Test.DelegateDemo
{
    internal class DelegateMenuBuilder
    {
        public static MainMenu BuildMenu()
        {
            MainMenu mainMenu = new MainMenu("Delegates Main Menu");

            MenuSubMenuItem dateTimeMenu =
                new MenuSubMenuItem("Show Current Date/Time");

            MenuSubMenuItem versionAndCapitalsMenu =
                new MenuSubMenuItem("Version and Capitals");

            dateTimeMenu.AddItem(
                new MenuActionItem(
                    "Show Current Date",
                    DelegateActions.ShowCurrentDate));

            dateTimeMenu.AddItem(
                new MenuActionItem(
                    "Show Current Time",
                    DelegateActions.ShowCurrentTime));

            versionAndCapitalsMenu.AddItem(
                new MenuActionItem(
                    "Count Capitals",
                    DelegateActions.CountCapitals));

            versionAndCapitalsMenu.AddItem(
                new MenuActionItem(
                    "Show Version",
                    DelegateActions.ShowVersion));

            mainMenu.RootMenu.AddItem(dateTimeMenu);
            mainMenu.RootMenu.AddItem(versionAndCapitalsMenu);

            return mainMenu;
        }
    }
}