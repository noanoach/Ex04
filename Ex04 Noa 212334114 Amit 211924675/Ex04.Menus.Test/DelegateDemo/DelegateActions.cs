using System;

namespace Ex04.Menus.Test.DelegateDemo
{
    internal static class DelegateActions
    {
        public static void ShowCurrentDate()
        {
            Console.WriteLine("> Current Date is {0}", DateTime.Now.ToShortDateString());
        }

        public static void ShowCurrentTime()
        {
            Console.WriteLine("> Current Time is {0}", DateTime.Now.ToLongTimeString());
        }

        public static void CountCapitals()
        {
            string input = Console.ReadLine();
            int capitalsCount = 0;

            foreach (char currentChar in input)
            {
                if (char.IsUpper(currentChar))
                {
                    capitalsCount++;
                }
            }

            Console.WriteLine(
                "There are {0} capital letters in your text.",
                capitalsCount);
        }

        public static void ShowVersion()
        {
            Console.WriteLine("App Version: 26.2.4.7310");
        }
    }
}