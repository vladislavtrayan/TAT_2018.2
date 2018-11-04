using System;

namespace Dev_5
{
    /// <summary>
    /// Processes commands and operates with them
    /// </summary>
    class CommandControl : ICommandControl
    {
        private Menu Menu { get; set; }
        private static CommandControl instance;
        public CarHouse CarHouse { get; set; }
        public CarCreator CarCreator { get; set; }
        private CommandControl ()
        {
            Menu = Menu.GetInstance();
            CarHouse = CarHouse.GetInstance();
        }
        static public CommandControl GetInstance()
        {
            if (instance == null)
            {
                instance = new CommandControl();
            }
            return instance;
        }
        /// <summary>
        /// Add new car to car house
        /// </summary>
        public void AddNewCar ()
        {
            Menu.Clear();
            try
            {
                CarCreator = CarCreator.GetInstance();
                Car newCar = CarCreator.CreateNewCar();
                CarHouse.AddNewCar(newCar);
            } catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
        }
        /// <summary>
        /// Show average car price in car house
        /// </summary>
        public void ShowAveragePrice ()
        {
            Menu.Clear();
            Console.WriteLine(CarHouse.GetAveragePrice());
        }
        /// <summary>
        /// Show average car price  with certain brand in car house
        /// </summary>
        public void ShowAveragePriceByType()
        {
            Menu.Clear();
            string brand = string.Empty;
            Console.Write("Input brand : ");
            brand = Console.ReadLine();
            Console.WriteLine(CarHouse.GetAveragePrice(brand));
        }
        /// <summary>
        /// Show capacity of cars in car house
        /// </summary>
        public void ShowCapacity()
        {
            Menu.Clear();
            Console.WriteLine(CarHouse.GetCapacity());
        }
        /// <summary>
        /// Show number of different brands in console
        /// </summary>
        public void ShowNumberOfTypes()
        {
            Menu.Clear();
            Console.WriteLine(CarHouse.CountTypes());
        }
    }
}
