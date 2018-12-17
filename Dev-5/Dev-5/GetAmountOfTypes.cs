using System;
namespace Dev_5
{
    /// <summary>
    /// Get amount of types in storage
    /// </summary>
    public class GetAmountOfTypes : ICommandControl
    {
        CarHouse carStorage;
        public void Execute()
        {
            Console.WriteLine("Amount of different types is " + carStorage.CountTypes());
        }
        public GetAmountOfTypes(CarHouse newCarHouse)
        {
            carStorage = newCarHouse;
        }
    }
}