using System;
using System.Collections.Generic;
namespace Dev_5
{
    public enum Commands
    {
        exit,
        countTypesCars,
        countTypesTrucks,
        countAllCars,
        countAllTrucks,
        averagePriceCars,
        averagePriceTrucks,
        averagePriceByTypeCars,
        averagePriceByTypeTrucks,
        unknown,
        execute
    }
    public struct CommandContent
    {
        public  Commands command;
        public string type;
    }
    /// <summary>
    /// Command handler.
    /// </summary>
    public class CommandHandler
    {
        ICommandControl commandControl;
        public MachineStorage CarStorage { get; set; }
        public MachineStorage TruckStorage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Dev_5.CommandHandler"/> class.
        /// </summary>
        /// <param name="carStorage">Car storage.</param>
        /// <param name="truckStorage">Truck storage.</param>
        public CommandHandler (MachineStorage carStorage , MachineStorage truckStorage)
        {
            CarStorage = carStorage;
            TruckStorage = truckStorage;
        }
        /// <summary>
        /// Handles the commands.
        /// </summary>
        public void  HandleCommands ()
        {
            Menu menu = Menu.GetInstance();
            List<ICommandControl> commandList = new List<ICommandControl>();
            bool endFlag = false;
            CommandContent commandContent;
            CommandReader commandReader = CommandReader.GetInstance();
            while (endFlag == false)
            {
                menu.Show();
                string[] inputStrings = Console.ReadLine().Split(' ');
                commandContent  = commandReader.GetCommand(inputStrings);
                commandControl = null;
                switch (commandContent.command)
                {
                    case Commands.exit:
                        endFlag = true;
                        break;
                    case Commands.countTypesCars:
                        commandControl = new GetAmountOfTypes(CarStorage);
                        break;
                    case Commands.countTypesTrucks:
                        commandControl = new GetAmountOfTypes(TruckStorage);
                        break;
                    case Commands.countAllCars:
                        commandControl = new GetAllAmountOf(CarStorage);
                        break;
                    case Commands.countAllTrucks:
                        commandControl = new GetAllAmountOf(TruckStorage);
                        break;
                    case Commands.averagePriceCars:
                        commandControl = new GetAveragePrice(CarStorage);
                        break;
                    case Commands.averagePriceTrucks:
                        commandControl = new GetAveragePrice(TruckStorage);
                        break;
                    case Commands.averagePriceByTypeCars:
                        commandControl = new GetAveragePriceByType(CarStorage, commandContent.type);
                        break;
                    case Commands.averagePriceByTypeTrucks:
                        commandControl = new GetAveragePriceByType(TruckStorage, commandContent.type);
                        break;
                    case Commands.execute:
                        foreach (ICommandControl i in commandList)
                        {
                            i.Excecute();
                        }
                        break;
                    case Commands.unknown:
                        Console.WriteLine("Unknown command");
                        break;
                }

                if (commandControl != null)
                {
                    commandList.Add(commandControl);
                }
            }
        }
    }
}
