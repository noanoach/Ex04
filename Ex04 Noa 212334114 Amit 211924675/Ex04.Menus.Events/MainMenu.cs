using System;

namespace Ex04.Menus.Events
{
    public class MainMenu
    {
        private readonly MenuSubMenuItem r_RootMenu;

        public MenuSubMenuItem RootMenu
        {
            get
            {
                return r_RootMenu;
            }
        }

        public MainMenu(string i_Title)
        {
            r_RootMenu = new MenuSubMenuItem(i_Title);
        }

        public void Show()
        {
            const bool v_IsRootMenu = true;

            showMenu(r_RootMenu, v_IsRootMenu);
        }

        private void showMenu(MenuSubMenuItem i_CurrentMenu, bool i_IsRootMenu)
        {
            bool shouldReturnToPreviousMenu = false;

            Console.Clear();

            while (!shouldReturnToPreviousMenu)
            {
                printMenu(i_CurrentMenu, i_IsRootMenu);

                int userChoice = readValidChoice(i_CurrentMenu, i_IsRootMenu);

                if (userChoice == 0)
                {
                    Console.Clear();
                    shouldReturnToPreviousMenu = true;
                }
                else
                {
                    handleMenuItemSelection(i_CurrentMenu.MenuItems[userChoice - 1]);
                }
            }
        }

        private void handleMenuItemSelection(MenuItem i_SelectedMenuItem)
        {
            const bool v_IsRootMenu = true;

            if (i_SelectedMenuItem is MenuSubMenuItem selectedSubMenuItem)
            {
                Console.Clear();
<<<<<<< HEAD
                showMenu(selectedSubMenuItem, !v_IsRootMenu);
=======
                showMenu(i_SelectedMenuItem as MenuSubMenuItem, false);
>>>>>>> f4e53daf2b7bd88f736437bf62ed1d8607dbb9c0
            }
            else if (i_SelectedMenuItem is MenuActionItem selectedActionItem)
            {
                selectedActionItem.Select();
                Console.WriteLine();
            }
        }

        private void printMenu(MenuSubMenuItem i_CurrentMenu, bool i_IsRootMenu)
        {
            printTitle(i_CurrentMenu.Title);
            printMenuItems(i_CurrentMenu);
            printBackOrExitOption(i_IsRootMenu);
            printChoiceRequest(i_CurrentMenu.MenuItems.Count, i_IsRootMenu);
        }

        private void printTitle(string i_Title)
        {
            string titleToPrint = string.Format("** {0} **", i_Title);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(titleToPrint);
            Console.WriteLine(new string('-', titleToPrint.Length));
            Console.ResetColor();
        }

        private void printMenuItems(MenuSubMenuItem i_CurrentMenu)
        {
            for (int i = 0; i < i_CurrentMenu.MenuItems.Count; ++i)
            {
                Console.WriteLine("{0}. {1}", i + 1, i_CurrentMenu.MenuItems[i].Title);
            }
        }

        private void printBackOrExitOption(bool i_IsRootMenu)
        {
            string backOrExitText = i_IsRootMenu ? "Exit" : "Back";

            Console.WriteLine("0. {0}", backOrExitText);
        }

        private void printChoiceRequest(int i_MaxChoice, bool i_IsRootMenu)
        {
            string backOrExitText = i_IsRootMenu ? "exit" : "go back";

            Console.WriteLine("Please enter your choice (1-{0} or 0 to {1}):", i_MaxChoice, backOrExitText);
            Console.Write(">> ");
        }

        private int readValidChoice(MenuSubMenuItem i_CurrentMenu, bool i_IsRootMenu)
        {
            int userChoice = -1;
            bool isValidChoice = false;

            while (!isValidChoice)
            {
                string userInput = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(userInput, out userChoice) && userChoice >= 0 && userChoice <= i_CurrentMenu.MenuItems.Count)
                {
                    isValidChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    printChoiceRequest(i_CurrentMenu.MenuItems.Count, i_IsRootMenu);
                }
            }

            return userChoice;
        }
    }
}