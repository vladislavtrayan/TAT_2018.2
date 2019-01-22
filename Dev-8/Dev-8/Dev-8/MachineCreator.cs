using System;

namespace Dev_5
{
    /// <summary>
    /// Creates IMachine objects
    /// </summary>
    class MachineCreator
    {
        private static MachineCreator instance;
        public static MachineCreator GetInstance()
        {
            if (instance == null)
            {
                instance = new MachineCreator();
            }
            return instance;
        }
        /// <summary>
        /// Create and return new IMachine object
        /// </summary>
        /// <returns>
        /// return new IMachine object
        /// </returns>
        public IMachine CreateNewCar(string brand,string model,
                                int capacity,double cost)
        {
            Car newCar = new Car(brand, model, capacity, cost);
            return newCar;
        }

        public IMachine CreateNewTruck(string brand, string model,
                                int capacity, double cost)
        {
            Truck newTruck = new Truck(brand, model, capacity, cost);
            return newTruck;
        }
    }
}
