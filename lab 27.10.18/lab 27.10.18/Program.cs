using System;


namespace lab_27._10._18
{
    class Program
    {
        /// <summary>
        /// Entry ponint of program
        /// </summary>
        /// <param name="args">argument is unused during the program</param>
        static void Main(string[] args)
        {
            try
            {
                Car blacMercedes = new Car("Actros", "mercedes", "black");
                Car blackLada = new Car("niva", "lada", "black");
                Car greenBmw = new Car("X7", "bmw", "green");
                Car greenLada = new Car("niva", "lada", "green");

                LinkedList listOfCars = new LinkedList();

                listOfCars.AddElement(blacMercedes);
                listOfCars.AddElement(blackLada);
                listOfCars.AddElement(greenBmw);
                listOfCars.AddElement(greenLada);

                LinkedList indexOfElements = new LinkedList();
                indexOfElements = listOfCars.Search(greenLada);
                indexOfElements.OutPut();
            }catch (Exception e )
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
