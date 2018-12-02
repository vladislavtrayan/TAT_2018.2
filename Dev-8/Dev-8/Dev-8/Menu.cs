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
            Console.WriteLine("Enter command : ");
            Console.WriteLine("Count_types Car(Truck)");
            Console.WriteLine("Count_all Car(Truck)");
            Console.WriteLine("Average_price Car(Truck)");
            Console.WriteLine("Average_price Car(Truck) Type");
            Console.WriteLine("Execute");
            Console.WriteLine("Exit");
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
