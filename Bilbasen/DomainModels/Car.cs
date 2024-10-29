using Microsoft.VisualBasic.FileIO;
using System.Drawing;

public class Car
{
    private string Brand { get; set; }
    private string Model { get; set; }
    private int Year { get; set; }
    private string Color { get; set; }
    private int MilageKm { get; set; }
    private string FuelType { get; set; }
    private int WeightKG { get; set; }
    private string CarClass { get; set; }
    private int Horsepower { get; set; }

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
    // neede for private 
    public string GetBrand() => Brand;
    public string GetModel() => Model;
    public int GetYear() => Year;
    public string GetColor() => Color;
    public int GetMilageKm() => MilageKm;
    public int GetWeightKG() => WeightKG;
    public string GetCarClass() => CarClass;
    public int GetHorsepower() => Horsepower;
    public string GetFuelType() => FuelType;


}
