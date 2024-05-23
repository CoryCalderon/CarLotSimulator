using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {//created the properties
        public int Year {  get; set; }
        public string Make {  get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //created the methods with string peramaters for each car
        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"My {Make} {Model}'s engine sounded like a {engineNoise}.");
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"My {Make} {Model}'s honk sounded like a {honkNoise}.");
        }
        //NOT PART OF EXERCISE.
        //Added if else line to notify user if the car still drives.
        public void Driveable(bool isDriveable)
        {
            if (isDriveable == true)
            {
                Console.WriteLine($"It drives perfectly!");
            }
            else
            {
                Console.WriteLine($"But it doesn't drive.");
            }
        }

        public Car() //created Default Constructor
        {
            CarLot._numberOfCars++;
        }
        //created filled constructor below to apply to the Program.cs. alternate option other than dot notation. 
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable) 
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            CarLot._numberOfCars++;
        }
    }
}
