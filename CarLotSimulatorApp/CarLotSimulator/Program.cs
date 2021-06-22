using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            var lot = new CarLot();

            //DONE - Create a seperate class file called Car
            //DONE - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE - The methods should take one string parameter: the respective noise property


            //DONE - Now that the Car class is created we can instanciate 3 new cars
            //DONE - Set the properties for each of the cars
            //DONE - Call each of the methods for each car

            var aprilsCar = new Car();
            aprilsCar.Make = "Ford";
            aprilsCar.Model = "Focus";
            aprilsCar.Year = 2013;
            aprilsCar.EngineNoise = "vroom";
            aprilsCar.HonkNoise = "beep";
            aprilsCar.IsDrivable = true;

            lot.Cars.Add(aprilsCar);

            var axlsCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDrivable = false
            };

            lot.Cars.Add(axlsCar);

            var dustysCar = new Car(2013,"Honda","Civic","vrroom","vruga",true);

            lot.Cars.Add(dustysCar);

            aprilsCar.MakeEngineNoise();
            axlsCar.MakeEngineNoise();
            dustysCar.MakeEngineNoise();

            //*************BONUS*************//

            // DONE - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE - Create a CarLot class
            //DONE - It should have at least one property: a List of cars
            //DONE - Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //DONE - At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
