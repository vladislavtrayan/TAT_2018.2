using System;
namespace Dev_5
{
    /// <summary>
    /// Get average price.
    /// </summary>
    public class GetAveragePrice : ICommandControl
    {
        MachineStorage machineStorage;
        public void Excecute ()
        {
            Console.WriteLine("Average price  in " + machineStorage.GetTypeOfElements() +
                             " storage  is " + machineStorage.GetAveragePrice());
        }
        public GetAveragePrice (MachineStorage newCarHouse)
        {
            machineStorage = newCarHouse;
        }
    }
}
