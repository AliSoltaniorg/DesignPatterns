using CarManufacturer.Models;

namespace CarManufacturer.Factories;

internal abstract class CarFactory
{
  public void CreateCar()
  {
    Car car = this.GetCar();
    car.Build();
    car.Design();
    car.Coloring();

    Console.WriteLine("Your car is ready!");
    Console.WriteLine();
  }

  public abstract Car GetCar();
}
