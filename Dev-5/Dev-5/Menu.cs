using System;


namespace Dev_5
{
    /// <summary>
    /// Represents menu
    /// </summary>
    class Menu
    {
        private static Menu instance;
        private Menu() { }
        static public Menu GetInstance()
        {
            if (instance == null)
            {
                instance = new Menu();
            }
            return instance;
        }
        /// <summary>
        /// Show menu functionality
        /// </summary>
        public void Show ()
        {
            Console.WriteLine("Choose command : ");
            Console.WriteLine("1 Add new car");
            Console.WriteLine("2 Count types");
            Console.WriteLine("3 Count all");
            Console.WriteLine("4 Average price");
            Console.WriteLine("5 Average price by types");
            Console.WriteLine("0 to exit");
        }
        /// <summary>
        /// Clear console window
        /// </summary>
        public void Clear ()
        {
            Console.Clear();
        }
    }
}
