public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int MilageKm { get; set; } 
    public string FuelType { get; set; } 
    public int WeightKG { get; set; } 
    public string CarClass { get; set; }
    public int Horsepower { get; set; }

    public Car(string brand, string model, int year, string color, int milageKm, string fuelType, int weightKG, string carClass, int horsepower)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
        MilageKm = milageKm;
        FuelType = fuelType;
        WeightKG = weightKG;
        CarClass = carClass;
        Horsepower = horsepower;
    }
}
