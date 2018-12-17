using System;
namespace Dev_5
{
    public class AddNewCar : ICommandControl
    {
        CarHouse carStorage;
        public string Type { get; set; }
        public void Execute()
        {
            CarCreator carCreator = CarCreator.GetInstance();
            carStorage.AddNewCar(carCreator.CreateNewCar());
        }
        public AddNewCar(CarHouse newCarHouse)
        {
            carStorage = newCarHouse;
        }
    }
}
