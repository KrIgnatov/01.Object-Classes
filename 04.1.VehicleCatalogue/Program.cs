using System;
using System.Collections.Generic;
using System.Linq;

class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}

class Catalog
{
    public List<Truck> Trucks { get; set; }
    public List<Car> Cars { get; set; }

    public Catalog()
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();
    }

    public void AddVehicle(string type, string brand, string model, int parameter)
    {
        if (type == "Truck")
        {
            Trucks.Add(new Truck { Brand = brand, Model = model, Weight = parameter });
        }
        else if (type == "Car")
        {
            Cars.Add(new Car { Brand = brand, Model = model, HorsePower = parameter });
        }
    }

    public void PrintCatalog()
    {
        Console.WriteLine("Cars:");
        foreach (Car car in Cars.OrderBy(c => c.Brand))
        {
            Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
        }

        if (Trucks.Any())
        {
            Console.WriteLine("Trucks:");
            foreach (Truck truck in Trucks.OrderBy(t => t.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Catalog catalog = new Catalog();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
                break;

            string[] vehicleData = input.Split('/');
            string type = vehicleData[0];
            string brand = vehicleData[1];
            string model = vehicleData[2];
            int parameter = int.Parse(vehicleData[3]);

            catalog.AddVehicle(type, brand, model, parameter);
        }

        catalog.PrintCatalog();
    }
}
