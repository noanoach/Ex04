using Ex04.Menus.Test.InterfaceDemo;
using Ex04.Menus.Test.DelegateDemo;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            runInterfacesMenu();
            runEventsMenu();
        }

        private static void runEventsMenu()
        {
            Ex04.Menus.Events.MainMenu eventsMainMenu =
                DelegateMenuBuilder.BuildMenu();

            eventsMainMenu.Show();
        }

        private static void runInterfacesMenu()
        {
            Ex04.Menus.Interfaces.MainMenu interfacesMainMenu = 
                InterfaceMenuBuilder.buildInterfacesMenu();

            interfacesMainMenu.Show();
        }

       
    }
}