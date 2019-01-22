using System;
namespace Dev_5
{
    /// <summary>
    /// Get all amount of Machine storage
    /// </summary>
    public class GetAllAmountOf : ICommandControl
    {
        CarHouse carStorage;
        public void Execute()
        {
            Console.WriteLine("Amount of elements is " + carStorage.GetCapacity());
        }
        public GetAllAmountOf(CarHouse newCarHouse)
        {
            carStorage = newCarHouse;
        }
    }
}