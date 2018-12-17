using System;
namespace Dev_5
{
    /// <summary>
    /// Read the divided string command
    /// and returns CommandContent
    /// </summary>
    public class CommandReader
    {
        CommandContent commandContent;
        private static CommandReader instance;
        private CommandReader()
        {
            commandContent = new CommandContent();
        }
        static public CommandReader GetInstance()
        {
            if (instance == null)
            {
                instance = new CommandReader();
            }
            return instance;
        }
        /// <summary>
        /// Read the divided string command
        /// and returns CommandContent
        /// </summary>
        /// <returns>
        /// The CommandContent with command
        /// and brand of machines if it was in devided console line
        /// </returns>
        /// <param name="devidedConsoleLine">
        /// splited console line
        /// </param>
        public CommandContent GetCommand(string[] devidedConsoleLine)
        {
            if (devidedConsoleLine[0].Equals("Add_new_car"))
            {
                commandContent.command = Commands.addNewCar;
                return commandContent;
            }
            else if (devidedConsoleLine[0].Equals("Exit"))
            {
                commandContent.command = Commands.exit;
                return commandContent;
            }
            else if (devidedConsoleLine[0].Equals("Count_types"))
            {
                commandContent.command = Commands.countTypesCars;
                return commandContent;
            }
            else if (devidedConsoleLine[0].Equals("Count_all"))
            {
                commandContent.command = Commands.countAllCars;
                return commandContent;
            }
            else if (devidedConsoleLine[0].Equals("Average_price"))

            {
                commandContent.command = Commands.averagePriceCars;
                return commandContent;
            }
            else if (devidedConsoleLine[0].Equals("Average_price"))
            {
                commandContent.command = Commands.averagePriceByTypeCars;
                commandContent.type = devidedConsoleLine[2];
                return commandContent;
            }
            else
            {
                commandContent.command = Commands.unknown;
                return commandContent;
            }
        }
    }
}