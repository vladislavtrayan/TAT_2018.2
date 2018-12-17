using System;
using System.Collections.Generic;
namespace Dev_5
{
    public enum Commands
    {
        exit,
        addNewCar,
        countTypesCars,
        countAllCars,
        averagePriceCars,
        averagePriceByTypeCars,
        unknown,
        execute
    }
    public struct CommandContent
    {
        public Commands command;
        public string type;
    }
    /// <summary>
    /// Command handler.
    /// </summary>
    public class CommandHandler
    {
        ICommandControl commandControl;
        public CarHouse CarStorage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Dev_5.CommandHandler"/> class.
        /// </summary>
        /// <param name="carStorage">Car storage.</param>
        public CommandHandler(CarHouse carStorage)
        {
            CarStorage = carStorage;
        }
        /// <summary>
        /// Handles the commands.
        /// </summary>
        public void HandleCommands()
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
                commandContent = commandReader.GetCommand(inputStrings);
                commandControl = null;
                switch (commandContent.command)
                {
                    case Commands.exit:
                        endFlag = true;
                        break;
                    case Commands.countTypesCars:
                        commandControl = new GetAmountOfTypes(CarStorage);
                        break;
                    case Commands.addNewCar:
                        commandControl = new AddNewCar(CarStorage);
                        commandControl.Execute();
                        break;
                    case Commands.countAllCars:
                        commandControl = new GetAllAmountOf(CarStorage);
                        commandControl.Execute();
                        break;
                    case Commands.averagePriceCars:
                        commandControl = new GetAveragePrice(CarStorage);
                        commandControl.Execute();
                        break;
                    case Commands.averagePriceByTypeCars:
                        commandControl = new GetAveragePriceByType(CarStorage, commandContent.type);
                        commandControl.Execute();
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