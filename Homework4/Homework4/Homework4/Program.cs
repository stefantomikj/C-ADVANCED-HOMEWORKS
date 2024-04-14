using System;
using System.Buffers.Text;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // *Filter all cars that have origin from Europe and print them in console.

            var originEurope = CarsData.Cars.Where( x => x.Origin == "Europe").ToList();
            PrintCars(originEurope);

           // * Filter all cars that have more than 6 Cylinders not including 6, after that Filter all cars that have exactly 4 Cylinders and have HorsePower more than 110

            var cylindersAndHorsePower = CarsData.Cars.Where(x =>  x.Cylinders > 6).ToList();
            var cylindersAndHorsePower2 = CarsData.Cars.Where(x => x.Cylinders == 4 && x.HorsePower > 110).ToList();
            var commonList = cylindersAndHorsePower.Concat(cylindersAndHorsePower2).ToList();
            PrintCars(commonList);


            //*Count all cars based on their Origin and print the result in console.Example outpur "US 10 models\n Eu 15 Models";

            var carCounts = CarsData.Cars
                .GroupBy(x => x.Origin)
                .Select(group => new { Origin = group.Key, Count = group.Count() });

            foreach (var car in carCounts)
            {
                Console.WriteLine($"{car.Origin} {car.Count} Models");
            }

            //* Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highes and average Miles per galon and print them in console;

            var cars200HP = CarsData.Cars.Where(x => x.HorsePower > 200);
            var lowestMPG = cars200HP.Min(x => x.MilesPerGalon);
            var highestMPG = cars200HP.Max(x => x.MilesPerGalon);
            var averageMPG = cars200HP.Average(x => x.MilesPerGalon);

            Console.WriteLine($"Lowest MPG: {lowestMPG}");
            Console.WriteLine($"Highest MPG: {highestMPG}");
            Console.WriteLine($"Average MPG: {averageMPG}");

            //* Find the top 3 fastest accelerating cars

            var fastestCars = CarsData.Cars.OrderBy(x => x.AccelerationTime).Take(3).ToList();
           
           
            foreach (Car car in fastestCars)
            {
                Console.WriteLine($"{car.Model} ({car.AccelerationTime} seconds)");
            }

            //  Calculate the total weight of cars with more than 6 cylinders: Calculate the total weight of cars with more than 6 cylinder

            var carWithMoreThen6Cylinders = CarsData.Cars.Where(x => x.Cylinders > 6).Select(x => x.Weight).Sum();
            Console.WriteLine($"Total weight {carWithMoreThen6Cylinders}");

            //*Find the average MilesPerGalon for cars with even number of cylinders:

            var carWithEvenCylinders = CarsData.Cars.Where(x => x.Cylinders % 2 == 0).Select(x => x.MilesPerGalon).Average();
            int carWithEvenCylindersNew = (int)carWithEvenCylinders;
            Console.WriteLine($"Average MilesPerGalon {carWithEvenCylindersNew}");

            
        }

        static void PrintCars(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.CarInfo()}");
            }
        }
    }
}
