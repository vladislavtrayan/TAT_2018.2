using System;

namespace Dev_5
{
    enum Commands
    {
        exit,
        addNewCar,
        countTypes,
        countAll,
        averagePrice,
        averagePriceByType
    }
    /// <summary>
    /// Entry point of program
    /// Class operates with cars in car house
    /// </summary>
    class Program
    {
        static void Main()
        {
            try
            {
                CommandControl commandControl = CommandControl.GetInstance();
                Menu menu = Menu.GetInstance();
                Commands command = 0;
                bool endFlag = false;
                while (endFlag == false)
                {
                    menu.Show();
                    Commands.TryParse(Console.ReadLine(), out command);
                    switch (command)
                    {
                        case Commands.exit:
                            endFlag = true;
                            break;
                        case Commands.addNewCar:
                            commandControl.AddNewCar();
                            Console.WriteLine();
                            break;
                        case Commands.countTypes:
                            commandControl.ShowNumberOfTypes();
                            Console.WriteLine();
                            break;
                        case Commands.countAll:
                            commandControl.ShowCapacity();
                            Console.WriteLine();
                            break;
                        case Commands.averagePrice:
                            commandControl.ShowAveragePrice();
                            Console.WriteLine();
                            break;
                        case Commands.averagePriceByType:
                            commandControl.ShowAveragePriceByType();
                            Console.WriteLine();
                            break;
                    }

                }
            } catch (Exception e )
            {
                Console.WriteLine("Error : " + e.Message);
            }
        }
    }
}
