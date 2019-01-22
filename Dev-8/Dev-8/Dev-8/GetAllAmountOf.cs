using System;
namespace Dev_5
{
    /// <summary>
    /// Get all amount of Machine storage
    /// </summary>
    public class GetAllAmountOf : ICommandControl
    {
        MachineStorage machineStorage;
        public void Excecute()
        {
            Console.WriteLine("Amount of elements in " + machineStorage.GetTypeOfElements() +
                              " is " + machineStorage.GetCapacity() );
        }
        public GetAllAmountOf(MachineStorage newCarHouse)
        {
            machineStorage = newCarHouse;
        }
    }
}
