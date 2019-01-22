using System;
namespace Dev_5
{
    /// <summary>
    /// represents a trucks of the same brand ,
    /// model and with a certain price
    /// </summary>
    public class Truck : IMachine
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public double Cost { get; set; }

        public Truck(string brand, string model, int capacity, double cost)
        {
            Brand = brand;
            Model = model;
            Capacity = capacity;
            Cost = cost;
        }
    }
}
