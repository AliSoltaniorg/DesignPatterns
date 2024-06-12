using CarManufacturer.Models;

namespace CarManufacturer.Factories;

internal sealed class MercedesBenzFactory : CarFactory
{
  public override Car GetCar()
  {
    return new MercedesBenzCar();
  }
}
