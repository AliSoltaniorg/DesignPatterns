using CarManufacturer.Models;

namespace CarManufacturer.Factories;

internal class GenericCarFactory<TCar> : CarFactory where TCar : Car, new()
{
  public override Car GetCar()
  {
    return new TCar();
  }
}
