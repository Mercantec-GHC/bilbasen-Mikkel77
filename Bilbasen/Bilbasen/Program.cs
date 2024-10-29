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
                // Set 1
                new Car("Ford", "Mustang", 1963, "Red", 43000, "Gasoline", 1600, "Sports", 271),
                new Car("Toyota", "Camry", 2020, "Blue", 20000, "Hybrid", 1500, "Sedan", 203),
                new Car("Chevrolet", "Corvette", 2022, "Silver", 6500, "Gasoline", 1400, "Sports", 495),
                new Car("BMW", "X5", 2018, "Black", 54000, "Diesel", 2100, "SUV", 335),
                new Car("Audi", "A4", 2019, "White", 30000, "Gasoline", 1500, "Sedan", 248),
                new Car("Mercedes", "E200", 2016, "Gray", 78000, "Diesel", 1700, "Sedan", 184),
                new Car("Honda", "Civic", 2015, "Blue", 65000, "Gasoline", 1300, "Compact", 143),
                new Car("Nissan", "Leaf", 2021, "Green", 15000, "Electric", 1400, "Hatchback", 147),
                new Car("Kia", "Sportage", 2022, "Red", 10000, "Gasoline", 1600, "SUV", 187),
                new Car("Volkswagen", "Golf", 2017, "Silver", 45000, "Diesel", 1350, "Hatchback", 150),

                // Set 2
                new Car("Ford", "Fiesta", 2012, "Yellow", 90000, "Gasoline", 1200, "Compact", 120),
                new Car("Toyota", "RAV4", 2018, "White", 40000, "Hybrid", 1650, "SUV", 194),
                new Car("Chevrolet", "Malibu", 2019, "Black", 30000, "Gasoline", 1500, "Sedan", 160),
                new Car("BMW", "3 Series", 2021, "Blue", 20000, "Gasoline", 1450, "Sedan", 255),
                new Car("Audi", "Q7", 2020, "Black", 22000, "Diesel", 2500, "SUV", 335),
                new Car("Mercedes", "S-Class", 2022, "White", 5000, "Electric", 2200, "Luxury", 496),
                new Car("Honda", "Accord", 2018, "Gray", 60000, "Gasoline", 1500, "Sedan", 252),
                new Car("Nissan", "Rogue", 2020, "Red", 25000, "Hybrid", 1600, "SUV", 201),
                new Car("Kia", "Sorento", 2017, "Blue", 75000, "Gasoline", 1700, "SUV", 240),
                new Car("Volkswagen", "Passat", 2016, "Gray", 85000, "Diesel", 1500, "Sedan", 150),

                // Set 3
                new Car("Ford", "Explorer", 2021, "Red", 15000, "Hybrid", 2000, "SUV", 300),
                new Car("Toyota", "Highlander", 2022, "Black", 12000, "Hybrid", 1800, "SUV", 243),
                new Car("Chevrolet", "Impala", 2015, "White", 90000, "Gasoline", 1600, "Sedan", 305),
                new Car("BMW", "X3", 2020, "Silver", 30000, "Diesel", 1600, "SUV", 248),
                new Car("Audi", "A6", 2017, "Gray", 40000, "Gasoline", 1550, "Sedan", 333),
                new Car("Mercedes", "GLC", 2022, "Blue", 12000, "Electric", 2000, "SUV", 402),
                new Car("Honda", "CR-V", 2016, "Green", 80000, "Gasoline", 1600, "SUV", 190),
                new Car("Nissan", "Altima", 2019, "Black", 30000, "Hybrid", 1500, "Sedan", 188),
                new Car("Kia", "Optima", 2018, "Gray", 50000, "Gasoline", 1550, "Sedan", 185),
                new Car("Volkswagen", "Tiguan", 2021, "Red", 10000, "Diesel", 1700, "SUV", 184),

                // Set 4
                new Car("Ford", "Bronco", 2021, "Blue", 20000, "Gasoline", 1800, "SUV", 310),
                new Car("Toyota", "Tacoma", 2020, "White", 45000, "Gasoline", 1900, "Truck", 278),
                new Car("Chevrolet", "Silverado", 2019, "Gray", 55000, "Diesel", 2200, "Truck", 277),
                new Car("BMW", "Z4", 2015, "Black", 70000, "Gasoline", 1400, "Sports", 335),
                new Car("Audi", "Q5", 2018, "Silver", 35000, "Diesel", 1800, "SUV", 240),
                new Car("Mercedes", "GLE", 2019, "White", 30000, "Diesel", 2100, "SUV", 362),
                new Car("Honda", "Pilot", 2019, "Gray", 40000, "Gasoline", 2000, "SUV", 280),
                new Car("Nissan", "Maxima", 2017, "Red", 60000, "Gasoline", 1600, "Sedan", 300),
                new Car("Kia", "Stinger", 2020, "Black", 25000, "Gasoline", 1700, "Sports", 368),
                new Car("Volkswagen", "Atlas", 2022, "Silver", 8000, "Diesel", 2000, "SUV", 276),

                // Set 5
                new Car("Ford", "Edge", 2022, "White", 12000, "Hybrid", 1800, "SUV", 250),
                new Car("Toyota", "Sienna", 2018, "Blue", 65000, "Gasoline", 1900, "Minivan", 263),
                new Car("Chevrolet", "Tahoe", 2021, "Black", 20000, "Gasoline", 2500, "SUV", 355),
                new Car("BMW", "M3", 2017, "Gray", 50000, "Gasoline", 1600, "Sports", 425),
                new Car("Audi", "A3", 2015, "Red", 75000, "Diesel", 1400, "Sedan", 150),
                new Car("Mercedes", "GLS", 2020, "Blue", 28000, "Diesel", 2400, "SUV", 362),
                new Car("Honda", "Insight", 2021, "Gray", 15000, "Hybrid", 1400, "Sedan", 151),
                new Car("Nissan", "Sentra", 2020, "Black", 25000, "Gasoline", 1300, "Compact", 149),
                new Car("Kia", "Rio", 2019, "White", 30000, "Gasoline", 1200, "Compact", 120),
                new Car("Volkswagen", "Jetta", 2016, "Silver", 65000, "Diesel", 1400, "Sedan", 150),

                // Set 6
                new Car("Ford", "Escort", 1985, "Blue", 120000, "Gasoline", 1100, "Compact", 90),
                new Car("Toyota", "Supra", 1994, "Red", 80000, "Gasoline", 1500, "Sports", 220),
                new Car("Chevrolet", "Blazer", 1988, "White", 150000, "Gasoline", 1800, "SUV", 140),
                new Car("BMW", "5 Series", 1990, "Black", 100000, "Diesel", 1800, "Sedan", 150),
                new Car("Audi", "80", 1983, "Gray", 90000, "Gasoline", 1200, "Sedan", 115),
                new Car("Mercedes", "300E", 1992, "Blue", 95000, "Diesel", 1800, "Sedan", 180),
                new Car("Honda", "Prelude", 1986, "Silver", 140000, "Gasoline", 1300, "Sports", 160),
                new Car("Nissan", "Pathfinder", 1999, "Green", 120000, "Gasoline", 1600, "SUV", 170),
                new Car("Kia", "Sephia", 1996, "Red", 110000, "Gasoline", 1200, "Compact", 100),
                new Car("Volkswagen", "Corrado", 1993, "Black", 70000, "Gasoline", 1400, "Sports", 178),

                // Set 7
                new Car("Ford", "Ranger", 2019, "Blue", 30000, "Diesel", 1700, "Truck", 270),
                new Car("Toyota", "4Runner", 2021, "Gray", 20000, "Gasoline", 2200, "SUV", 270),
                new Car("Chevrolet", "Traverse", 2020, "White", 25000, "Gasoline", 2000, "SUV", 310),
                new Car("BMW", "i3", 2017, "Black", 60000, "Electric", 1350, "Hatchback", 168),
                new Car("Audi", "Q8", 2019, "Blue", 22000, "Gasoline", 2200, "SUV", 335),
                new Car("Mercedes", "G-Class", 2020, "Silver", 10000, "Diesel", 2400, "SUV", 416),
                new Car("Honda", "Fit", 2018, "Red", 35000, "Gasoline", 1200, "Compact", 128),
                new Car("Nissan", "Titan", 2021, "Gray", 10000, "Diesel", 2500, "Truck", 400),
                new Car("Kia", "Soul", 2022, "Yellow", 12000, "Gasoline", 1300, "Crossover", 147),
                new Car("Volkswagen", "Arteon", 2020, "White", 20000, "Diesel", 1700, "Sedan", 268),

                // Set 8
                new Car("Ford", "Fusion", 2017, "Gray", 50000, "Hybrid", 1600, "Sedan", 188),
                new Car("Toyota", "Prius", 2021, "Green", 15000, "Hybrid", 1400, "Hatchback", 121),
                new Car("Chevrolet", "Camaro", 2020, "Black", 25000, "Gasoline", 1800, "Sports", 455),
                new Car("BMW", "M2", 2019, "Blue", 15000, "Gasoline", 1400, "Sports", 405),
                new Car("Audi", "S5", 2021, "Silver", 12000, "Gasoline", 1500, "Coupe", 349),
                new Car("Mercedes", "C-Class", 2020, "White", 18000, "Gasoline", 1600, "Sedan", 255),
                new Car("Honda", "Ridgeline", 2018, "Red", 40000, "Gasoline", 2000, "Truck", 280),
                new Car("Nissan", "Armada", 2019, "Gray", 22000, "Gasoline", 2300, "SUV", 400),
                new Car("Kia", "Telluride", 2021, "Black", 12000, "Gasoline", 1900, "SUV", 291),
                new Car("Volkswagen", "ID.4", 2022, "Blue", 10000, "Electric", 1400, "SUV", 201),

                // Set 9
                new Car("Ford", "Expedition", 2018, "Black", 60000, "Diesel", 2500, "SUV", 400),
                new Car("Toyota", "Land Cruiser", 2020, "Silver", 20000, "Gasoline", 2500, "SUV", 381),
                new Car("Chevrolet", "Equinox", 2021, "Red", 15000, "Hybrid", 1600, "SUV", 182),
                new Car("BMW", "X6", 2019, "White", 30000, "Gasoline", 2200, "SUV", 335),
                new Car("Audi", "RS7", 2020, "Gray", 10000, "Gasoline", 2100, "Sedan", 591),
                new Car("Mercedes", "SLK", 2015, "Blue", 50000, "Gasoline", 1600, "Convertible", 302),
                new Car("Honda", "Passport", 2021, "Gray", 12000, "Gasoline", 1800, "SUV", 280),
                new Car("Nissan", "Murano", 2020, "Black", 20000, "Gasoline", 1700, "SUV", 260),
                new Car("Kia", "Forte", 2019, "Silver", 30000, "Gasoline", 1500, "Sedan", 147),
                new Car("Volkswagen", "Polo", 2016, "Yellow", 55000, "Diesel", 1200, "Compact", 108),

                // Set 10
                new Car("Ford", "Escape", 2019, "Gray", 20000, "Hybrid", 1500, "SUV", 165),
                new Car("Toyota", "C-HR", 2018, "Blue", 30000, "Gasoline", 1300, "Crossover", 144),
                new Car("Chevrolet", "Suburban", 2020, "White", 18000, "Diesel", 2600, "SUV", 355),
                new Car("BMW", "X1", 2021, "Red", 10000, "Gasoline", 1600, "SUV", 228),
                new Car("Audi", "A1", 2017, "Black", 45000, "Diesel", 1200, "Compact", 115),
                new Car("Mercedes", "EQC", 2021, "Silver", 5000, "Electric", 2000, "SUV", 402),
                new Car("Honda", "Odyssey", 2020, "Gray", 25000, "Gasoline", 2200, "Minivan", 280),
                new Car("Nissan", "Kicks", 2021, "Green", 10000, "Gasoline", 1300, "Crossover", 122),
                new Car("Kia", "Seltos", 2020, "White", 15000, "Gasoline", 1400, "SUV", 146),
                new Car("Volkswagen", "Passat", 2021, "Blue", 8000, "Diesel", 1700, "Sedan", 174),

            };


            var firstCars = cars.Where(car => car.GetBrand() == "Ford").ToList();
            Console.WriteLine("fordCars:");
            foreach (var car in firstCars)
            {
                Console.WriteLine($"{car.GetYear()} {car.GetBrand()} {car.GetModel()}  Color: {car.GetColor()}, Mileage: {car.GetMilageKm()} km, Fuel Type: {car.GetFuelType()}, Weight: {car.GetWeightKG()} kg, Class: {car.GetCarClass()}, Horsepower: {car.GetHorsepower()}");                
            }
            
            var hp = cars.Where(car => car.GetHorsepower() >= 200).ToList();
            Console.WriteLine("\ncars with more then over 200 Horsepower:");
            foreach (var car in hp)
            {
                Console.WriteLine($"{car.GetYear()} {car.GetBrand()} {car.GetModel()}  Color: {car.GetColor()}, Mileage: {car.GetMilageKm()} km, Fuel Type: {car.GetFuelType()}, Weight: {car.GetWeightKG()} kg, Class: {car.GetCarClass()}, Horsepower: {car.GetHorsepower()}");
            }

            var color = cars.Where(car => car.GetColor() == "Red").ToList();
            Console.WriteLine("\nred cars:");
            foreach (var car in color)
            {
                Console.WriteLine($"{car.GetYear()} {car.GetBrand()} {car.GetModel()}  Color: {car.GetColor()}, Mileage: {car.GetMilageKm()} km, Fuel Type: {car.GetFuelType()}, Weight: {car.GetWeightKG()} kg, Class: {car.GetCarClass()}, Horsepower: {car.GetHorsepower()}");
            }

            var carCount = cars.Count(Car => Car.GetBrand() == "Ford");
            Console.WriteLine($"\nDer er {carCount} Ford cars");

            var carsin1980to1999 = cars.Where(car => car.GetYear() >= 1980 && car.GetYear() <= 1999).ToList();
            Console.WriteLine("\ncars from 1980 to 1999: ");
            foreach (var car in carsin1980to1999)
            {
                Console.WriteLine($"{car.GetYear()} {car.GetBrand()} {car.GetModel()}  Color: {car.GetColor()}, Mileage: {car.GetMilageKm()} km, Fuel Type: {car.GetFuelType()}, Weight: {car.GetWeightKG()} kg, Class: {car.GetCarClass()}, Horsepower: {car.GetHorsepower()}");
            }
        }
    }
}