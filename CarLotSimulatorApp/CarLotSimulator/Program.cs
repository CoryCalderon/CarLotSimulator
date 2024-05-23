using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //using custom constructor
            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            //*************BONUS X 2*************//
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            //Instanciated the CarLot
            var carsOwned = new CarLot();
            var carsWanted = new CarLot();

            Console.WriteLine($"Current number of cars in the car lot: {CarLot._numberOfCars}");
            //instanciated the 3 new cars
            Car myFirstCar = new Car();
            Console.WriteLine($"Current number of cars in the car lot: {CarLot._numberOfCars}");
            Car mySecondCar = new Car();
            Console.WriteLine($"Current number of cars in the car lot: {CarLot._numberOfCars}");
            Car myCurrentCar = new Car();
            Console.WriteLine($"Current number of cars in the car lot: {CarLot._numberOfCars}");
            //used dot notationand divided by property
            myFirstCar.Make = "Dodge";
            mySecondCar.Make = "Mitubishi";
            myCurrentCar.Make = "Chevy";

            //Added cars to carsOwned lot
            carsOwned.ParkingLot.Add(myFirstCar);
            carsOwned.ParkingLot.Add(mySecondCar);
            carsOwned.ParkingLot.Add(myCurrentCar);

            myFirstCar.Model = "Dakota";
            mySecondCar.Model = "Gallant";
            myCurrentCar.Model = "Malibu";

            myFirstCar.Year = 1998;
            mySecondCar.Year = 2007;
            myCurrentCar.Year = 2013;

            myFirstCar.EngineNoise = "pig squealing";
            mySecondCar.EngineNoise = "mouse";
            myCurrentCar.EngineNoise = "old microwave";

            myFirstCar.HonkNoise = "saxaphone";
            mySecondCar.HonkNoise = "trumpet";
            myCurrentCar.HonkNoise = "trumbone";

            myFirstCar.IsDriveable = false;
            mySecondCar.IsDriveable = false;
            myCurrentCar.IsDriveable = true;


            //used "filled constructor" from car class to add new car to our car lot through the program. Could have used constructor to start.
            var dreamCar = new Car(2024, "Mercedes", "C-Class", "cat purring", "robot", true);
            carsWanted.ParkingLot.Add(dreamCar);

            carsOwned.CheckCars();
            carsWanted.CheckCars();

            

        }
    }
}
