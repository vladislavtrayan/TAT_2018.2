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
        public void Show()
        {
            Console.WriteLine("Enter command : ");
            Console.WriteLine("Add_new_car");
            Console.WriteLine("Count_types");
            Console.WriteLine("Count_all");
            Console.WriteLine("Average_price");
            Console.WriteLine("Average_price Type");
            Console.WriteLine("Exit");
        }
        /// <summary>
        /// Clear console window
        /// </summary>
        public void Clear()
        {
            Console.Clear();
        }
    }
}