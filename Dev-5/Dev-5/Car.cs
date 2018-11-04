namespace Dev_5
{
    /// <summary>
    /// represents a cars of the same brand ,
    /// model and with a certain price
    /// </summary>
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public double Cost { get; set; }
        public Car(string brand,string model,int capacity,double cost)
        {
            Brand = brand;
            Model = model;
            Capacity = capacity;
            Cost = cost;
        }

    }
}
