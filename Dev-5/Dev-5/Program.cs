using System;

namespace Dev_5
{

    /// <summary>
    /// Entry point of program
    /// Class operates with cars in car house
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarHouse carStorage = CarHouse.GetInstance();
                CommandHandler commandHandler = new CommandHandler(carStorage);
                commandHandler.HandleCommands();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
        }
    }
}