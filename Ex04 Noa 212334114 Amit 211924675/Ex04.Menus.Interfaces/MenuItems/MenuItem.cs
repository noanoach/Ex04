namespace Ex04.Menus.Interfaces.MenuItems
{

    // Represents a single item in the menu hierarchy.
    public abstract class MenuItem
    {
        private readonly string r_Title;

        public string Title
        {
            get
            {
                return r_Title;
            }
        }

        protected MenuItem(string i_Title)
        {
            r_Title = i_Title;
        }
    }
}