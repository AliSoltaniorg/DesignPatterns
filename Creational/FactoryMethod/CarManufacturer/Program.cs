using CarManufacturer.Factories;
using CarManufacturer.Models;

CarFactory mercedesBenzFactory = new MercedesBenzFactory();
CarFactory teslaFactory = new TeslaFactory();

mercedesBenzFactory.CreateCar();
teslaFactory.CreateCar();

Console.WriteLine();
Console.WriteLine("--------------- Generic Factory ---------------");

GenericCarFactory<TeslaCar> teslaCarFactory = new();

teslaCarFactory.CreateCar();

