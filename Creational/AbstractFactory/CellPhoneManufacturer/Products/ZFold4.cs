using CellPhoneManufacturer.Interfaces;

namespace CellPhoneManufacturer.Products;

internal class ZFold4 : IFlipScreen
{
  public void AssembleFlipScreen() =>
    Console.WriteLine($"Assemble Flip Screen: {GetType().Name}");
}
