using System;
using System.Collections.Generic;

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
                XmlParser xmlParser = new XmlParser();
                List<IMachine> trucks = xmlParser.ParseXml(args[0]);
                List<IMachine> cars =  xmlParser.ParseXml(args[1]);
                MachineStorage carStorage = new MachineStorage(cars);
                MachineStorage truckStorage = new MachineStorage(trucks);
                CommandHandler commandHandler = new CommandHandler(carStorage, truckStorage);
                commandHandler.HandleCommands();
            } catch (Exception e )
            {
                Console.WriteLine("Error : " + e.Message);
            }
        }
    }
}
