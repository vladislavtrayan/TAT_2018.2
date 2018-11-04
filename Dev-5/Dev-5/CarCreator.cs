using System;

namespace Dev_5
{
    /// <summary>
    /// Creates Car objects
    /// </summary>
    class CarCreator
    {
        private static CarCreator instance;
        public static CarCreator GetInstance()
        {
            if (instance == null)
            {
                instance = new CarCreator();
            }
            return instance;
        }
        /// <summary>
        /// Create and return new Car object
        /// </summary>
        /// <returns>
        /// return new Car object
        /// </returns>
        public Car CreateNewCar()
        {
            string brand = string.Empty;
            string model = string.Empty;
            int capacity = 0;
            double cost = 0.0;
            Console.Write("Input car brand :");
            brand = Console.ReadLine();
            Console.Write("Input car model :");
            model = Console.ReadLine();
            Console.Write("Input car capacity :");
            int.TryParse(Console.ReadLine(), out capacity);
            Console.Write("Input car cost :");
            double.TryParse(Console.ReadLine(), out cost);
            Car newCar = new Car(brand, model,capacity, cost);
            return newCar;
        }
    }
}
