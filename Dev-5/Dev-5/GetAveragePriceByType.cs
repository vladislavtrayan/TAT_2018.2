using System;
namespace Dev_5
{
    /// <summary>
    /// Get average price by type.
    /// </summary>
    public class GetAveragePriceByType : ICommandControl
    {
        CarHouse carStorage;
        public string Type { get; set; }
        public void Execute()
        {
            Console.WriteLine("Average price  in storage by type " + Type + " is " + carStorage.GetAveragePrice(Type));
        }
        public GetAveragePriceByType(CarHouse newCarHouse, string type)
        {
            carStorage = newCarHouse;
            Type = type;
        }
    }
}