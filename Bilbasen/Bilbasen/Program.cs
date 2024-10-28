using System;
using System.Collections.Generic;
using System.Linq;

namespace Bilbasen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car("Ford", "Mustang", 1963, "Red", 43000, "Gasoline", 1600, "Sports", 271),
                new Car("Toyota", "Camry", 2020, "Blue", 20000, "Hybrid", 1500, "Sedan", 203),
                new Car("Chevrolet", "Corvette", 2022, "Silver", 6500, "Gasoline", 1400, "Sports", 495),
                new Car("BMW", "X5", 2018, "Black", 54000, "Diesel", 2100, "SUV", 335),
                new Car("Audi", "A4", 2019, "White", 30000, "Gasoline", 1500, "Sedan", 248),
                new Car("Mercedes", "E200", 2016, "Gray", 78000, "Diesel", 1700, "Sedan", 184),
                // Add the rest of the cars...
                new Car("Ford", "F-150", 2019, "Black", 45000, "Diesel", 2200, "Truck", 290),
                new Car("Toyota", "Sequoia", 2021, "Green", 15000, "Gasoline", 2500, "SUV", 381)
            };

            var fordCars = cars.Where(car => car.Brand == "Ford").ToList();

            foreach (var car in fordCars)
            {
                Console.WriteLine($"{car.Year} {car.Brand} {car.Model}  Color: {car.Color}, Mileage: {car.MileageKm} km, Fuel Type: {car.FuelType}, Weight: {car.WeightKG} kg, Class: {car.CarClass}, Horsepower: {car.Horsepower}");
            }
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int MileageKm { get; set; }
        public string FuelType { get; set; }
        public int WeightKG { get; set; }
        public string CarClass { get; set; }
        public int Horsepower { get; set; }

        public Car(string brand, string model, int year, string color, int mileageKm, string fuelType, int weightKG, string carClass, int horsepower)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            MileageKm = mileageKm;
            FuelType = fuelType;
            WeightKG = weightKG;
            CarClass = carClass;
            Horsepower = horsepower;
        }
    }
}
