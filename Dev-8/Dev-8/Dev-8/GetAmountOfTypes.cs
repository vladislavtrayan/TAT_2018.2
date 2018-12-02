using System;
namespace Dev_5
{
    /// <summary>
    /// Get amount of types in storage
    /// </summary>
    public class GetAmountOfTypes : ICommandControl
    {
        MachineStorage machineStorage;
        public void Excecute()
        {
            Console.WriteLine("Amount of different types in " + machineStorage.GetTypeOfElements() +
                              " is " + machineStorage.CountTypes());
        }
        public GetAmountOfTypes(MachineStorage newCarHouse)
        {
            machineStorage = newCarHouse;
        }
    }
}
