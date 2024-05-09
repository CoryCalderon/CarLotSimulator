using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {//Created new CarLot.cs. made it as a list of cars from our Car.cs.
     //Made it equal to new list of car as default.
        public List<Car> ParkingLot {  get; set; } = new List<Car>();

        //created a method CheckCars.
        public void CheckCars()
        {
            //Created foreach 'car' in ParkingLot.
            //Added new writeline for make,model,year.
            //Made new methods to call previous writeline in Car.cs to each corresponding car.
            //Now program.cs will write out the writelines for each car in a given ParkingLot
            foreach (var car in ParkingLot)
            {
                Console.WriteLine($"{car.Make} {car.Model}, made in the year {car.Year}.");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
                car.Driveable(car.IsDriveable);
                Console.WriteLine();
            }
        }
    }
}
