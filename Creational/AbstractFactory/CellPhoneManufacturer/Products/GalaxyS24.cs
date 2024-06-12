using CellPhoneManufacturer.Interfaces;

namespace CellPhoneManufacturer.Products;

internal class GalaxyS24 : ITouchScreen
{
  public void AssembleScreen() =>
    Console.WriteLine($"Assemble Touch Screen: {GetType().Name}");
}
