using System;
using System.Collections.Generic;

namespace Dev_5
{
    /// <summary>
    /// represents a car house 
    /// </summary>
    class CarHouse
    {
        private static CarHouse instance;
        private List<Car> carHouse;
        
        private CarHouse ()
        {
            carHouse = new List<Car>();
        }
        public static CarHouse  GetInstance ()
        {
            if (instance == null)
            {
                instance = new CarHouse();
            }
            return instance;
        }
        /// <summary>
        /// Add new object Car to Car House
        /// if the same car exist in car house
        /// method summ capacities
        /// if there are different prices of the same cars
        /// it throws exception
        /// </summary>
        /// <param name="newCar">
        /// object of Car class
        /// </param>
        public void AddNewCar (Car newCar)
        {
            bool checkFlag = false;
            foreach (Car i in carHouse)
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
                carHouse.Add(newCar);
            }
        }
        /// <summary>
        /// Count and return whole car capacity in car house
        /// </summary>
        /// <returns>
        /// Car house capacity
        /// </returns>
        public int GetCapacity ()
        {
            int capacity = 0;
            foreach (Car i in carHouse)
            {
                capacity += i.Capacity;
            }
            return capacity;
        }
        /// <summary>
        /// Calculate average price of all cars in the car house
        /// </summary>
        /// <returns>
        /// returns average price of all cars in the car house
        /// </returns>
        public double GetAveragePrice ()
        {
            double averagePrice = new double();
            int capacity = 0;
            foreach (Car i in carHouse)
            {
                averagePrice += i.Cost;
                capacity += i.Capacity;
            }
            averagePrice = averagePrice / capacity;

            return averagePrice;
        }
        /// <summary>
        /// Calculate average price of all cars with certain brand
        /// </summary>
        /// <param name="brand">
        /// string brand 
        /// </param>
        /// <returns>
        /// retruns average price of all cars with certain brand
        /// </returns>
        public double GetAveragePrice (string brand)
        {
            double averagePrice = new double();
            int capacity = 0;
            foreach (Car i in carHouse)
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
        /// Count all different brands in car house
        /// </summary>
        /// <returns>
        /// returns number of different brands in car house 
        /// </returns>
        public int CountTypes ()
        {
            int typeCounter = 0;
            string temporaryString = string.Empty;
            foreach (Car i in carHouse)
            {
                if (!temporaryString.Contains(i.Brand))
                {
                    typeCounter++;
                }
            }
            return typeCounter;
        }
    }
}
