using System.Collections.Generic;
using System;

/*
 * Class Data for FuelSystemName, Consumable, UnitOfMeasure
 */
public class FuelSystemName
{
    internal string ID;
    public string Name { get; set; }
    public List<String> FuelTypes { get; set; }
    public string TankCapacity { get; set; }
}

public class Consumable
{
    public int ID { get; set; }
    public string Description { get; set; }
}

public class UnitOfMeasure
{
    public int ID { get; set; }
    public string Description { get; set; }
}

/*
 * Main application for creating data in the console
 */
class Program
{
    static void Main(string[] args)
    {
        List<FuelSystemName> fuelTrucks = new List<FuelSystemName>();
        FuelSystemName truck1 = new FuelSystemName
        {
            Name = "FuelTruck",
            ID = "001",
            FuelTypes = new List<string> { "Diesel"},
            TankCapacity = "10,000 Gallons"

        };
        fuelTrucks.Add(truck1);

        FuelSystemName truck2 = new FuelSystemName
        {
            Name = "FuelTruck",
            ID = "002",
            FuelTypes = new List<string> { "Gasoline" },
            TankCapacity = "5,000 Liters"
        };
        fuelTrucks.Add(truck2);

        FuelSystemName truck3 = new FuelSystemName
        {
            Name = "FuelTruck",
            ID = "003",
            FuelTypes = new List<string> { "Gasoline" },
            TankCapacity = "5,000 Liters"
        };
        fuelTrucks.Add(truck2);

        Console.WriteLine("Fuel System Name, Tank Capacity, Fuel Info");
        foreach (FuelSystemName truck in fuelTrucks)
        {
            Console.WriteLine(truck.Name + truck.ID + "," + truck.TankCapacity + "," + string.Join(", ", truck.FuelTypes));
        }
        Console.ReadLine();
    }
}

