using System;
namespace Dev_5
{
    /// <summary>
    /// Get average price.
    /// </summary>
    public class GetAveragePrice : ICommandControl
    {
        CarHouse carStorage;
        public void Execute()
        {
            Console.WriteLine("Average price  in storage  is " + carStorage.GetAveragePrice());
        }
        public GetAveragePrice(CarHouse newCarHouse)
        {
            carStorage = newCarHouse;
        }
    }
}