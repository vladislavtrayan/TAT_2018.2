namespace lab_27._10._18
{
    /// <summary>
    /// Represents a car 
    /// with fields : Model,Brand,Color
    /// </summary>
    class Car 
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="model">model of new car object</param>
        /// <param name="brand">brand of new car object</param>
        /// <param name="color">color of new car object</param>
        public Car (string model,string brand,string color)
        {
            Model = model;
            Brand = brand;
            Color = color;
        }
        /// <summary>
        /// Class constructor
        /// Copy all fields of argument object
        /// </summary>
        /// <param name="initialCar">reference on a Car object</param>
        public Car(ref Car initialCar)
        {
            Model = initialCar.Model;
            Brand = initialCar.Brand;
            Color = initialCar.Color;
        }

    }
}
