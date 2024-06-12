using CellPhoneManufacturer.Interfaces;

namespace CellPhoneManufacturer.Products;

internal class X20 : ITouchScreen
{
  public void AssembleScreen() =>
    Console.WriteLine($"Assemble Touch Screen: {GetType().Name}");
}
