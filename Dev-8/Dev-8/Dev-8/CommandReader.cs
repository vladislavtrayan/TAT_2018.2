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
        private CommandReader ()
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
            if ((devidedConsoleLine.Length == 1) &&
                (devidedConsoleLine[0].Equals("Execute")))
            {
                commandContent.command = Commands.execute;
                return commandContent;
            }
            else if ((devidedConsoleLine.Length == 1) &&
                     (devidedConsoleLine[0].Equals("Exit")))
            {
                commandContent.command = Commands.exit;
                return commandContent;
            }
            else if ((devidedConsoleLine.Length == 2) &&
                     (devidedConsoleLine[0].Equals("Count_types")) &&
                     ((devidedConsoleLine[1].Equals("Car")) ||
                      (devidedConsoleLine[1].Equals("Truck"))))
            {
                if (devidedConsoleLine[1].Equals("Car"))
                {
                    commandContent.command = Commands.countTypesCars;
                }
                else
                {
                    commandContent.command = Commands.countTypesTrucks;
                }
                return commandContent;
            }
            else if ((devidedConsoleLine.Length == 2) &&
                     (devidedConsoleLine[0].Equals("Count_all")) &&
                     ((devidedConsoleLine[1].Equals("Car")) ||
                      (devidedConsoleLine[1].Equals("Truck"))))
            {
                if (devidedConsoleLine[1].Equals("Car"))
                {
                    commandContent.command = Commands.countAllCars;
                }
                else
                {
                    commandContent.command = Commands.countAllTrucks;
                }
                return commandContent;
            }
            else if ((devidedConsoleLine.Length == 2) &&
                     (devidedConsoleLine[0].Equals("Average_price")) &&
                     ((devidedConsoleLine[1].Equals("Car")) ||
                      (devidedConsoleLine[1].Equals("Truck"))))

            {
                if (devidedConsoleLine[1].Equals("Car"))
                {
                    commandContent.command = Commands.averagePriceCars;
                }
                else
                {
                    commandContent.command = Commands.averagePriceTrucks;
                }
                return commandContent;
            }
            else if ((devidedConsoleLine.Length == 3) &&
                     (devidedConsoleLine[0].Equals("Average_price")))
            {
                if (devidedConsoleLine[1].Equals("Car"))
                {
                    commandContent.command = Commands.averagePriceByTypeCars;
                    commandContent.type = devidedConsoleLine[2];
                }
                else
                {
                    commandContent.command = Commands.averagePriceByTypeTrucks;
                    commandContent.type = devidedConsoleLine[2];
                }
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
