using System;
using System.Collections.Generic;

namespace Dev_5
{
    /// <summary>
    /// represents a IMachine storage 
    /// </summary>
    public class MachineStorage
    {
        private List<IMachine> machineStorage;
        
        public MachineStorage(List<IMachine> machines)
        {
            machineStorage = new List<IMachine>();
            foreach (IMachine i in machines)
            {
                machineStorage.Add(i);
            }
        }

        /// <summary>
        /// Add new object IMachine to IMachine storage
        /// if the same IMachine exist in IMachine storage
        /// method summ capacities
        /// if there are different prices of the same cars
        /// it throws exception
        /// </summary>
        /// <param name="newMachine">
        /// object of IMachine class
        /// </param>
        public void AddNewCar (IMachine newMachine)
        {
            bool checkFlag = false;
            foreach (IMachine i in machineStorage)
            {
                if (i.Brand == newCar.Brand &&
                    i.Model == newCar.Model)
                {
                    if (i.Cost != newCar.Cost )
                    {
                        throw new Exception ("Not correct input");
                    }
                    i.Capacity += newCar.Capacity;
                    checkFlag = true;
                }
            }
            if (checkFlag == false)
            {
                machineStorage.Add(newCar);
            }
        }
        /// <summary>
        /// Count and return whole IMachine capacity in IMachine storage
        /// </summary>
        /// <returns>
        /// IMachine storage capacity
        /// </returns>
        public int GetCapacity ()
        {
            int capacity = 0;
            foreach (IMachine i in machineStorage)
            {
                capacity += i.Capacity;
            }
            return capacity;
        }
        /// <summary>
        /// Calculate average price of all machines in the IMachine storage
        /// </summary>
        /// <returns>
        /// returns average price of all machines in the IMachine storage
        /// </returns>
        public double GetAveragePrice ()
        {
            if (machineStorage == null)
            {
                throw new Exception("Machine storage is empty");
            }

            double averagePrice = new double();
            int capacity = 0;
            foreach (IMachine i in machineStorage)
            {
                averagePrice += i.Cost;
                capacity += i.Capacity;
            }
            averagePrice = averagePrice / capacity;

            return averagePrice;
        }
        /// <summary>
        /// Calculate average price of all machines with certain brand
        /// </summary>
        /// <param name="brand">
        /// string brand 
        /// </param>
        /// <returns>
        /// retruns average price of all machines with certain brand
        /// </returns>
        public double GetAveragePrice (string brand)
        {
            if (machineStorage == null)
            {
                throw new Exception("Machine storage is empty");
            }

            double averagePrice = new double();
            int capacity = 0;
            foreach (IMachine i in machineStorage)
            {
                if (i.Brand == brand)
                {
                    capacity += i.Capacity;
                    averagePrice += i.Cost;
                }
            }
            averagePrice = averagePrice / capacity;
            return averagePrice;
        }
        /// <summary>
        /// Count all different brands in IMachine storage
        /// </summary>
        /// <returns>
        /// returns number of different brands in IMachine storage 
        /// </returns>
        public int CountTypes ()
        {
            if (machineStorage == null)
            {
                throw new Exception("Machine storage is empty");
            }

            int typeCounter = 0;
            string temporaryString = string.Empty;
            foreach (IMachine i in machineStorage)
            {
                if (!temporaryString.Contains(i.Brand))
                {
                    typeCounter++;
                }
            }
            return typeCounter;
        }
        /// <summary>
        /// Checks the first storage element on its type 
        /// </summary>
        /// <returns>
        /// The type of first element in storage
        /// </returns>
        public string GetTypeOfElements ()
        {
            if (machineStorage == null)
            {
                throw new Exception("Machine storage is empty");
            }

            IMachine machine = machineStorage[0];
            if (machine is Car)
            {
                return "Car";
            }
            else if (machine is Truck)
            {
                return "Truck";
            }
            else
            {
                throw new Exception("There are no cars or trucks in storage");
            }
        }
    }
}
