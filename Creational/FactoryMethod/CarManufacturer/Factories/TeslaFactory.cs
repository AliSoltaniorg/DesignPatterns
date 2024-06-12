using CarManufacturer.Models;

namespace CarManufacturer.Factories;

internal sealed class TeslaFactory : CarFactory
{
  public override Car GetCar()
  {
    return new TeslaCar();
  }
}
