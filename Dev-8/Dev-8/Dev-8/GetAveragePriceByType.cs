using System;
namespace Dev_5
{
    /// <summary>
    /// Get average price by type.
    /// </summary>
    public class GetAveragePriceByType : ICommandControl
    {
        MachineStorage machineStorage;
        public string Type { get; set; }
        public void Excecute()
        {
            Console.WriteLine("Average price  in " + machineStorage.GetTypeOfElements() +
                              " storage by type " + Type + " is " + machineStorage.GetAveragePrice(Type));
        }
        public GetAveragePriceByType(MachineStorage newCarHouse,string type)
        {
            machineStorage = newCarHouse;
            Type = type;
        }
    }
}
